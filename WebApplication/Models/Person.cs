using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.Json.Serialization;

namespace Models {
public class Person {
    
    public int id { get; set; }
    [NotNull]
    public string firstName { get; set; }
    [NotNull]
    public string lastName { get; set; }
    [ValidHairColor]
    public string hairColor { get; set; }
    [NotNull]
    [ValidEyeColor]
    public string eyeColor { get; set; }
    [NotNull, Range(0, 125)]
    public int age { get; set; }
    [NotNull, Range(1, 250)]
    public float weight { get; set; }
    [NotNull, Range(30, 250)]
    public int height { get; set; }
    [NotNull]
    public string sex { get; set; }

    public void Update(Person toUpdate) {
        age = toUpdate.age;
        height = toUpdate.height;
        hairColor = toUpdate.hairColor;
        sex = toUpdate.sex;
        weight = toUpdate.weight;
        eyeColor = toUpdate.eyeColor;
        firstName = toUpdate.firstName;
        lastName = toUpdate.lastName;
    }

}

public class ValidHairColor : ValidationAttribute {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
        List<string> valid = new[] {"blond", "red", "brown", "black",
            "white", "grey", "blue", "green", "leverpostej"}.ToList();
        if (valid == null || valid.Contains(value.ToString().ToLower())) {
            return ValidationResult.Success;
        }
        return new ValidationResult("Valid hair colors are: Blond, Red, Brown, Black, White, Grey, Blue, Green, Leverpostej");
    }
}

public class ValidEyeColor : ValidationAttribute {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext) {
        List<string> valid = new[] {"brown", "grey", "green", "blue",
            "amber", "hazel"}.ToList();
        if (valid != null && valid.Contains(value.ToString().ToLower())) {
            return ValidationResult.Success;
        }
        return new ValidationResult("Valid hair colors are: Brown, Grey, Green, Blue, Amber, Hazel");
    }
}

}