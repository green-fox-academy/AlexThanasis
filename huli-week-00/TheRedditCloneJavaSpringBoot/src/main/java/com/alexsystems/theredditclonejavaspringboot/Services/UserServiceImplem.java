package com.alexsystems.theredditclonejavaspringboot.Services;

import com.alexsystems.theredditclonejavaspringboot.Models.User;
import com.alexsystems.theredditclonejavaspringboot.Repositories.UserRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.crypto.bcrypt.BCrypt;
import org.springframework.stereotype.Service;

@Service
public class UserServiceImplem implements UserService {

    @Autowired
    UserRepository userRepository;

    @Override
    public User save(User user) {
        userRepository.save(user);
        return user;
    }

    @Override
    public User register(User user) {
        user.setPassword(passwordEncoder(user.getPassword()));
        save(user);
        return user;
    }

    @Override
    public boolean isAdminEmail(User user) {
        if (user.getEmail().matches("^([a-zA-Z0-9_\\.-]+)@greenfoxacademy.com")) {
            user.setAdmin(true);
            save(user);
            return true;
        }
        return false;
    }

    public boolean isAdmin(User user) {
        return user.isAdmin();
    }

    @Override
    public boolean isExistingEmail(String email) {
        return false;
    }

    @Override
    public boolean isExistingName(String name) {
        return findOneByName(name) != null;
    }

    @Override
    public boolean isValidPassword(String password, String confirm) {
        return password.length() >= 8 && password.equals(confirm);
    }

    @Override
    public boolean isValidEmail(String email) {
        return email.matches("^([a-zA-Z0-9_\\.-]+)@greenfoxacademy.com") || email.matches
                ("^[a-zA-Z0-9_+&*-]+(?:\\." +
                        "[a-zA-Z0-9_+&*-]+)*@" +
                        "(?:[a-zA-Z0-9-]+\\.)+[a-z" +
                        "A-Z]{2,7}$");
    }

    @Override
    public boolean isInputFieldEmpty(User user, String confirm) {
        return user.getEmail().length() < 1 || user.getPassword().length() < 1 ||
                user.getName().length() < 1 || confirm.length() < 1;
    }

    @Override
    public String errorHandler(User user, String confirm) {
        if (!isValidEmail(user.getEmail()) || !isValidPassword(user.getPassword(), confirm)) {
            return "Your email address or password is not correct. Please try again!";
        } else if (isInputFieldEmpty(user, confirm)) {
            return "Please fill all fields!";
        } else if (isExistingEmail(user.getEmail())) {
            return "This email address is already exists!";
        }
        return null;
    }

    @Override
    public User findOneByEmail(String email) {
        return userRepository.findOneByEmail(email);
    }

    @Override
    public User findOneByName(String name) {
        return userRepository.findOneByName(name);
    }

    @Override
    public String passwordEncoder(String password) {
        return BCrypt.hashpw(password, BCrypt.gensalt(12));
    }

    @Override
    public boolean isPasswordValid(String password, String hashedPassword) {
        return BCrypt.checkpw(password, hashedPassword);
    }

    @Override
    public String loginErrorHandler(String email, String password) {
        if (findOneByEmail(email) == null || !isPasswordValid(password, findOneByEmail(email).getPassword())) {
            return "Wrong email or password.";
        }
        return null;
    }
}
