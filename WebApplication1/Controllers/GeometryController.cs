using Microsoft.AspNetCore.Mvc;
using GeometryCalculatorWebApp.Models;

namespace GeometryCalculatorWebApp.Controllers
{
    // Kontroler obs³uguj¹cy ¿¹dania dotycz¹ce kalkulacji geometrycznych
    public class GeometryController : Controller
    {
        // Metoda obs³uguj¹ca ¿¹dania GET na œcie¿ce /Geometry/Index
        [HttpGet]
        public IActionResult Index()
        {
            // Zwraca widok Index.cshtml
            return View();
        }

        // Metoda obs³uguj¹ca ¿¹dania POST na œcie¿ce /Geometry/Calculate
        [HttpPost]
        public IActionResult Calculate([FromBody] ShapeModel model)
        {
            // Obliczanie ró¿nych w³aœciwoœci prostok¹ta na podstawie modelu
            double area = model.CalculateArea();
            double perimeter = model.CalculatePerimeter();
            double diagonal = model.CalculateDiagonal();
            double totalEdgeLength = model.CalculateTotalEdgeLength();

            // Tworzenie obiektu wynikowego zawieraj¹cego obliczone wartoœci
            var result = new
            {
                Area = area,
                Perimeter = perimeter,
                Diagonal = diagonal,
                TotalEdgeLength = totalEdgeLength
            };

            // Zwracanie wyników w formacie JSON do klienta
            return Json(result);
        }
    }
}