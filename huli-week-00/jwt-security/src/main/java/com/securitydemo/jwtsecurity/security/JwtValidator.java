package com.securitydemo.jwtsecurity.security;

import org.springframework.stereotype.Component;

@Component
public class JwtValidator {

    private String secret;

    public Object validate(String token) {

        Claims claims = Jwts.parser()
                .setSingingKey(secret);
        return null;
    }
}
