package com.alexsystems.theredditclonejavaspringboot.Controllers;

import com.alexsystems.theredditclonejavaspringboot.Services.RedditService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class RedditController {

    @Autowired
    RedditService redditService;

    @GetMapping("")
    public String renderIndex(Model model){
        model.addAttribute("posts", redditService.FindAllPosts());
        return "index";
    }
}
