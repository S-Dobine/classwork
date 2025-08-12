package com.Server.controller;

import com.Server.dao.PetServiceImplementation;
import com.Server.model.Pet;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/v1")
public class PetApiController {

    PetServiceImplementation thePetService;

    public PetApiController(PetServiceImplementation thePetService) {
        this.thePetService = thePetService;
    }


    @GetMapping("/pets")
    public List<Pet> getAllPets() {
        return thePetService.getAllPets();
   }

    @PostMapping("/pets")
    public Pet addAPet(@RequestBody Pet newPet) {
        return thePetService.addPet(newPet);
    }
}
