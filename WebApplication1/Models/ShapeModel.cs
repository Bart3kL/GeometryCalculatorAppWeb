namespace GeometryCalculatorWebApp.Models
{
    // Model reprezentuj�cy prostok�t i zawieraj�cy metody do oblicze� geometrycznych
    public class ShapeModel
    {
        // W�a�ciwo�� przechowuj�ca szeroko�� prostok�ta
        public double Width { get; set; }

        // W�a�ciwo�� przechowuj�ca wysoko�� prostok�ta
        public double Height { get; set; }

        // Metoda obliczaj�ca powierzchni� prostok�ta
        public double CalculateArea()
        {
            // Powierzchnia prostok�ta to szeroko�� razy wysoko��
            return Width * Height;
        }

        // Metoda obliczaj�ca obw�d prostok�ta
        public double CalculatePerimeter()
        {
            // Obw�d prostok�ta to suma d�ugo�ci wszystkich bok�w,
            // czyli 2 razy szeroko�� plus 2 razy wysoko��
            return 2 * (Width + Height);
        }

        // Metoda obliczaj�ca przek�tn� prostok�ta
        public double CalculateDiagonal()
        {
            // Przek�tna prostok�ta jest obliczana przy u�yciu twierdzenia Pitagorasa
            // pierwiastek kwadratowy z sumy kwadrat�w szeroko�ci i wysoko�ci
            return Math.Sqrt(Width * Width + Height * Height);
        }

        // Metoda obliczaj�ca sum� d�ugo�ci wszystkich bok�w prostok�ta
        public double CalculateTotalEdgeLength()
        {
            // Suma d�ugo�ci wszystkich bok�w to 2 razy szeroko�� plus 2 razy wysoko��
            return 2 * Width + 2 * Height;
        }
    }
}