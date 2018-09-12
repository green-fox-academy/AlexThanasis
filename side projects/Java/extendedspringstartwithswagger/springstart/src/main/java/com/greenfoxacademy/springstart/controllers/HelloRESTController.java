package com.greenfoxacademy.springstart.controllers;

import io.swagger.annotations.Api;
import io.swagger.annotations.ApiOperation;
import io.swagger.annotations.ApiResponse;
import io.swagger.annotations.ApiResponses;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import java.util.List;
import java.util.concurrent.atomic.AtomicLong;

@RestController
@RequestMapping(path = "/api/hellos/")
@Api(value = "HelloRESTControllerAPI", produces = MediaType.APPLICATION_JSON_VALUE)
public class HelloRESTController {

    AtomicLong atomicLong = new AtomicLong(1);
    /*
    @RequestMapping(value = "/greeting")
    @ResponseBody
    public Greeting greeting(@RequestParam(value = "name") String name) {
        return new Greeting(atomicLong.getAndIncrement(), "Hello " + name);
    }

    @RequestMapping(value = "/greetme")
    @ResponseBody
    public Greeting greetme(){
        return new Greeting(atomicLong.getAndIncrement(), "Hello Alex");
    }
    */
    @GetMapping("/greetmeowner")
    public Greeting greetmeowner() {
        return new Greeting(atomicLong.getAndIncrement(), "Hello Alex");
    }

    @ApiOperation("Gets the user with specific ID")
    @ApiResponses(value = {@ApiResponse(code = 200, message = "OK", response = Greeting.class)})
    @GetMapping("/greetmeuser/{name}")
    public Greeting greetmeuser(@PathVariable("name") String name){
        return new Greeting(atomicLong.getAndIncrement(), "Hello " + name);
    }
}
