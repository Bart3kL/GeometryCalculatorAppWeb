namespace GeometryCalculatorWebApp.Models
{
    // Model reprezentuj¹cy prostok¹t i zawieraj¹cy metody do obliczeñ geometrycznych
    public class ShapeModel
    {
        // W³aœciwoœæ przechowuj¹ca szerokoœæ prostok¹ta
        public double Width { get; set; }

        // W³aœciwoœæ przechowuj¹ca wysokoœæ prostok¹ta
        public double Height { get; set; }

        // Metoda obliczaj¹ca powierzchniê prostok¹ta
        public double CalculateArea()
        {
            // Powierzchnia prostok¹ta to szerokoœæ razy wysokoœæ
            return Width * Height;
        }

        // Metoda obliczaj¹ca obwód prostok¹ta
        public double CalculatePerimeter()
        {
            // Obwód prostok¹ta to suma d³ugoœci wszystkich boków,
            // czyli 2 razy szerokoœæ plus 2 razy wysokoœæ
            return 2 * (Width + Height);
        }

        // Metoda obliczaj¹ca przek¹tn¹ prostok¹ta
        public double CalculateDiagonal()
        {
            // Przek¹tna prostok¹ta jest obliczana przy u¿yciu twierdzenia Pitagorasa
            // pierwiastek kwadratowy z sumy kwadratów szerokoœci i wysokoœci
            return Math.Sqrt(Width * Width + Height * Height);
        }

        // Metoda obliczaj¹ca sumê d³ugoœci wszystkich boków prostok¹ta
        public double CalculateTotalEdgeLength()
        {
            // Suma d³ugoœci wszystkich boków to 2 razy szerokoœæ plus 2 razy wysokoœæ
            return 2 * Width + 2 * Height;
        }
    }
}