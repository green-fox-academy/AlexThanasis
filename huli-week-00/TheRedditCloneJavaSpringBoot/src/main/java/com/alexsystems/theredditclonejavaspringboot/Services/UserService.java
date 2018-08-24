package com.alexsystems.theredditclonejavaspringboot.Services;

import com.alexsystems.theredditclonejavaspringboot.Models.User;

import java.util.List;

public interface UserService {
    User save(User user);
    User register(User user);
    User findOneByEmail(String email);
    boolean isAdminEmail(User user);
    boolean isValidPassword(String password, String confirm);
    boolean isValidEmail(String email);
    boolean isInputFieldEmpty(User user, String confirm);
    boolean isPasswordValid(String password, String hashedPassword);
    boolean isAdmin(User user);
    boolean isExistingEmail(String email);
    String errorHandler(User user, String confirm);
    String passwordEncoder(String password);
    String loginErrorHandler(String email, String password);
}
