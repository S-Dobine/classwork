package Pet;



/* Data                         Behavior (Methods)
*   Name of Pet
*   Type of Pet
*   Gender
*   Weight (lbs)
*   Spayed or Neutered?
* */

import java.util.Objects;

public class Pet {

    private String petName;
    private String petType;
    private char petGender;
    private int petWeight;
    private boolean isSpayed;


    public Pet() {}

    public String getPetName() {
        return petName;
    }

    public void setPetName(String petName) {
        this.petName = petName;
    }

    public String getPetType() {
        return petType;
    }

    public void setPetType(String petType) {
        this.petType = petType;
    }

    public char getPetGender() {
        return petGender;
    }

    public void setPetGender(char petGender) {
        this.petGender = petGender;
    }

    public int getPetWeight() {
        return petWeight;
    }

    public void setPetWeight(int petWeight) {
        this.petWeight = petWeight;
    }

    public boolean isSpayed() {
        return isSpayed;
    }

    public void setSpayed(boolean spayed) {
        isSpayed = spayed;
    }

    @Override
    public String toString() {
        return "Pet{" +
                "petName='" + petName + '\'' +
                ", petType='" + petType + '\'' +
                ", petGender=" + petGender +
                ", petWeight=" + petWeight +
                ", isSpayed=" + isSpayed +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (!(o instanceof Pet pet)) return false;
        return getPetGender() == pet.getPetGender() && getPetWeight() == pet.getPetWeight() && isSpayed() == pet.isSpayed() && Objects.equals(getPetName(), pet.getPetName()) && Objects.equals(getPetType(), pet.getPetType());


    }

    @Override
    public int hashCode() {
        return Objects.hash(getPetName(), getPetType(), getPetGender(), getPetWeight(), isSpayed());
    }
public void hashCodeIO {
        return Objects.hash(getPetName(),getPetType(),getPetGender(),getPetWeight(),)
    }

    public Pet(String petName, String petType, char petGender, int petWeight, boolean isSpayed) {
        this.petName = petName;
        this.petType = petType;
        this.petGender = petGender;
        this.petWeight = petWeight;
        this.isSpayed = isSpayed;


    }
}


