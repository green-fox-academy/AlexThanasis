package com.alexsystems.theredditclonejavaspringboot.Models;

import java.util.Date;

public class Post {
    private long id;
    private String content;
    private String url;
    private Date createdAt;
    private int score;
    private long userId;

    public Post(String content, String url, Date createdAt, int score, long userId) {
        this.content = content;
        this.url = url;
        this.createdAt = createdAt;
        this.score = score;
    }

    public Post() {
    }

    public String getContent() {
        return content;
    }

    public void setContent(String content) {
        this.content = content;
    }

    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public Date getCreatedAt() {
        return createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }

    public int getScore() {
        return score;
    }

    public void setScore(int score) {
        this.score = score;
    }

    public long getUserId() {
        return userId;
    }

    public void setUserId(long userId) {
        this.userId = userId;
    }
}
