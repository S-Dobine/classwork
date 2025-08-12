package com.Server.dao;

import com.Server.model.Pet;
import jakarta.transaction.Transactional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;

import java.util.List;
import java.util.Optional;

@Service
public class PetServiceImplementation implements IPet {
   PetRepository thePetRepository;

   @Autowired
   public PetServiceImplementation (PetRepository thePetRepository){
       this.thePetRepository = thePetRepository;
   }

    @Override
    public String toString() {
        return "PetServiceImplementation{" +
                "thePetRepository=" + thePetRepository +
                '}';
    }

    @Override
    public List<Pet> getAllPets() {
        return thePetRepository.findAll();
    }

    @Override
    public Optional<Pet> returnPet(int pkey) {
        return thePetRepository.findById(pkey);
    }

    @Override
    public Pet addPet(Pet aPet) {
        return thePetRepository.save(aPet);
    }

    @Override
    public Pet updatePet(Pet aPet) {
        return thePetRepository.save(aPet);
    }

    @Override
    @Transactional
    public void deletePet(int priKey) {




    }
}
