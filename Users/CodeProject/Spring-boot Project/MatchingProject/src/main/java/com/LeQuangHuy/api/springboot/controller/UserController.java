package com.LeQuangHuy.API.springboot.controller;

import com.LeQuangHuy.API.springboot.model.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import com.LeQuangHuy.API.springboot.security.service.UserService;

import java.util.List;

@RestController
@RequestMapping("/users")
public class UserController {

    @Autowired
    private UserService userService;

    public UserController(UserService userService) {

        this.userService = userService;
    }
    @GetMapping
    public List<User> getUsers() {

        return userService.getAllUsers();
    }
}
