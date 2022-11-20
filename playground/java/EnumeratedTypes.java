public class EnumeratedTypes
{
    public static void main(String[] args)
    {
        var brand_new_car = new Car("Bob", Car.colors.GREEN);

        brand_new_car.announce();
    }
}

public class Car
{
    String owner;
    colors color;
    public static enum colors {BLUE, RED, GREEN, BLACK, WHITE};

    public Car(String owner, Car.colors color)
    {
        this.owner = owner;
        this.color = color;
    }

    public void announce()
    {
        String color;
        switch (this.color)
        {
            case BLUE -> color = "blue";
            case RED -> color = "red";
            case GREEN -> color = "green";
            case BLACK -> color = "black";
            case WHITE -> color = "white";
            default -> color = "";
        }
        System.out.printf("%s has a new %s car!", this.owner, color);
    }
}