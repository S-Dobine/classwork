package com.Server.model;

import jakarta.persistence.*;
import jakarta.persistence.criteria.CriteriaBuilder;
import org.springframework.instrument.classloading.InstrumentationLoadTimeWeaver;

import java.util.Objects;

@Entity
@Table(name = "")

public class Pet {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    @Column (name = "pet_id")
    private Integer petId;

    @Column (name = "name")
    private String petName;

    @Column (name = "pet_type_id")
    private Integer petTypeId;

    @Column (name = "owner_id")
    private Integer ownerId;


    public Pet() {}

    public Pet(Integer petId, String petName, Integer petTypeId, Integer ownerId) {

        this.petId = petId;
        this.petName = petName;
        this.petTypeId = petTypeId;
        this.ownerId = ownerId;
    }

    public Integer getPetId() {
        return petId;
    }

    public void setPetId(Integer petId) {
        this.petId = petId;
    }

    public String getPetName() {
        return petName;
    }

    public void setPetName(String petName) {
        this.petName = petName;
    }

    public Integer getPetTypeId() {
        return petTypeId;
    }

    public void setPetTypeId(Integer petTypeId) {
        this.petTypeId = petTypeId;
    }

    public Integer getOwnerId() {
        return ownerId;
    }

    public void setOwnerId(Integer ownerId) {
        this.ownerId = ownerId;
    }

    @Override
    public boolean equals(Object o) {
        if (!(o instanceof Pet pet)) return false;
        return Objects.equals(getPetId(), pet.getPetId()) && Objects.equals(getPetName(), pet.getPetName()) && Objects.equals(getPetTypeId(), pet.getPetTypeId()) && Objects.equals(getOwnerId(), pet.getOwnerId());
    }

    @Override
    public int hashCode() {
        return Objects.hash(getPetId(), getPetName(), getPetTypeId(), getOwnerId());
    }

    @Override
    public String toString() {
        return "Pet{" +
                "petId=" + petId +
                ", petName='" + petName + '\'' +
                ", petTypeId=" + petTypeId +
                ", ownerId=" + ownerId +
                '}';
    }




}
