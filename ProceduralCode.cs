namespace knightmoves;
public class ProceduralCode {
    public void Run(){
        Rectangle rectangle = new Rectangle(1, 2);
        int area = rectangle.CalculateArea();
    }
}

// Add your code here
public class Rectangle{ 
    private int length;
    private int height;

    public Rectangle (int length, int height){
        this.length = length;
        this.height = height;
    }

    public int CalculateArea(){
        return length * height;
    }
}

//should encapsulate the variables and methods within a Rectangle class
//should pass the variables into the Rectangle as constructor arguments
//should have a CalculateArea method that takes no arguments