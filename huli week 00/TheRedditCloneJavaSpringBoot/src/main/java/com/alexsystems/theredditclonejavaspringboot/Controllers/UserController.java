package com.alexsystems.theredditclonejavaspringboot.Controllers;

import com.alexsystems.theredditclonejavaspringboot.Models.User;
import com.alexsystems.theredditclonejavaspringboot.Repositories.UserRepository;
import com.alexsystems.theredditclonejavaspringboot.Services.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpSession;

@Controller
public class UserController {

    private UserService userService;
    private UserRepository userRepository;

    @Autowired
    public UserController(UserService userService, UserRepository userRepository) {
        this.userService = userService;
        this.userRepository = userRepository;
    }

    @GetMapping("/registration")
    public String renderRegistrationPage(@ModelAttribute User user, Model model) {
        model.addAttribute("user", new User());
        return "registration";
    }

    @PostMapping("/registration")
    public String signUp(@ModelAttribute User user,
                         @RequestParam(name = "confirm") String confirm,
                         HttpServletRequest request, Model model) {
        String errorMessage = userService.errorHandler(user, confirm);
        model.addAttribute("error", errorMessage);
        if (errorMessage != null) {
            return "registration";
        }
        userService.register(user);
        HttpSession session = request.getSession();
        session.setAttribute("session", userService.findOneByEmail(user.getEmail()).getEmail());
        if (userService.isAdminEmail(user)) {
            return "redirect:/admin/profile";
        }
        return "redirect:/user/profile/";
    }

    @GetMapping("/admin/profile")
    public String renderAdminProfile(HttpSession session, Model model) {
        Object sessionObject = session.getAttribute("session");
        if (sessionObject == null) {
            return "redirect:/login";
        }
        model.addAttribute("sessionEmail", sessionObject);
        return "adminprofile";
    }

    @GetMapping("/user/profile")
    public String renderUserProfile(HttpSession session, Model model) {
        Object sessionObject = session.getAttribute("session");
        if (sessionObject == null) {
            return "redirect:/login";
        }
        model.addAttribute("sessionEmail", sessionObject);
        return "userprofile";
    }

    @GetMapping("/login")
    public String renderLoginPage() {
        return "login";
    }

    @PostMapping("/login")
    public String login(@RequestParam(name = "email")String email,
                        @RequestParam(name = "password")String password, Model model, HttpServletRequest request) {
        String errorMessage = userService.loginErrorHandler(email, password);
        model.addAttribute("error", errorMessage);
        if (errorMessage != null) {
            return "login";
        }
        HttpSession session = request.getSession();
        User user = userService.findOneByEmail(email);
        session.setAttribute("session", user.getEmail());
        if (userService.isAdmin(user)) {
            return "redirect:/admin/profile";
        }
        return "redirect:/user/profile";
    }
}
