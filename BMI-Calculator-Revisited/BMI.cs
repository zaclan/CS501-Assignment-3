namespace BMI_Calculator_Revisited.BMI;

internal class BMI
{
    private string gender;
    private int height;
    private double weight;
    private int age;

    public BMI()
    {
        this.gender = "";
        this.height = -1;
        this.weight = -1;
        this.age = -1;
    }

    public BMI(string gender, int height, double weight, int age)
    {
        this.gender = gender;
        this.height = height;
        this.weight = weight;
        this.age = age;
    }

    // ACCESSORS
    public string getGender() { return this.gender;  }
    public int getHeight() { return this.height; }
    public double getWeight() { return this.weight; }
    public int getAge() { return this.age;  }

    // MODIFIERS
    public void setGender(string gender) {
        if (gender != "m" && gender != "f") throw new ArgumentException("Gender must be m or f");
        this.gender = gender; 
    }
    public void setHeight(string heightStr) {
        if (!int.TryParse(heightStr, out int height)) throw new ArgumentException("Height must be an integer");
        if (height < 0) throw new ArgumentException("Height cannot be negative");
        this.height = height;   
    }
    public void setWeight(string weightStr) {
        if (!double.TryParse(weightStr, out double weight)) throw new ArgumentException("Weight must be a double");
        if (weight < 0) throw new ArgumentException("Weight cannot be negative");
        this.weight = weight;
    }
    public void setAge(string ageStr) {
        if (!int.TryParse(ageStr, out int age)) throw new ArgumentException("Age must be an integer");
        if (age < 0) throw new ArgumentException("Age cannot be negative");
        this.age = age;
    }

    // CALCULATE BMI
    public double calculateBMI()
    {
        return this.weight / Math.Pow(this.height, 2) * 703;
    }
}
