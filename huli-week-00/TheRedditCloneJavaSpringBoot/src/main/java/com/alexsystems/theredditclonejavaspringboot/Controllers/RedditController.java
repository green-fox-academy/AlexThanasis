package com.alexsystems.theredditclonejavaspringboot.Controllers;

import com.alexsystems.theredditclonejavaspringboot.Models.Post;
import com.alexsystems.theredditclonejavaspringboot.Services.RedditService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;

@Controller
public class RedditController {

    @Autowired
    RedditService redditService;

    @GetMapping("")
    public String renderIndex(Model model){
        model.addAttribute("posts", redditService.FindAllPosts());
        return "index";
    }

    @GetMapping("/createpost")
    public String getToSubmit (Model model){
        model.addAttribute("post", new Post());
        return "submit";
    }

    @PostMapping("/createpost")
    public String addPost (@ModelAttribute Post post){
        redditService.addPost(post);
        return "redirect:/";
    }

    @PostMapping("/upvote")
    public String upVote(@ModelAttribute(value = "id") Long id){
        redditService.upvoteSelectedPost(id);
        return "redirect:/";
    }

    @PostMapping("/downvote")
    public String downVote(@ModelAttribute(value = "id") Long id){
        redditService.downvoteSelectedPost(id);
        return "redirect:/";
    }

    @GetMapping("{id}/getviewimage")
    public String getViewImage(@PathVariable(value="id") Long id, Model model){
        model.addAttribute("post", redditService.getPostById(id));
        return "viewimage";
    }
}
