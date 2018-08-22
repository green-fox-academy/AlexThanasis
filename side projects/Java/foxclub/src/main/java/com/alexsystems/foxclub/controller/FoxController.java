package com.alexsystems.foxclub.controller;

import com.alexsystems.foxclub.model.Fox;
import com.alexsystems.foxclub.service.FoxService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;

public class FoxController {

    @Autowired
    FoxService foxService;

    @GetMapping("")
    public String renderIndex(Model model){
        model.addAttribute("foxes", foxService.FindAllFoxes());
        return "index";
    }

    @GetMapping("/addnewfox")
    public String getToAddNewFox(Model model){
        model.addAttribute("fox", new Fox());
        return "addnewfox";
    }

    @PostMapping("/addnewfox")
    public String addNewFox(@ModelAttribute Fox fox){
        foxService.addFox(fox);
        return "redirect:/";
    }

    @GetMapping("/view/{id}")
    public String getViewFox(@PathVariable(value="id") Long id, Model model){
        model.addAttribute("fox", foxService.getFoxById(id));
        return "view";
    }

    @GetMapping("/view/{id}/edit")
    public String getEditExistingFox(@PathVariable(value="id") Long id, Model model){
        model.addAttribute("fox", foxService.getFoxById((id)));
        return "edit";
    }

    @PutMapping("/view/{id}/edit")
    public String editExistingFox(@ModelAttribute(value ="id") Long id){
        return "view";
    }
}
