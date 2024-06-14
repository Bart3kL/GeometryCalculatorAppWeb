using Microsoft.AspNetCore.Mvc;
using GeometryCalculatorWebApp.Models;

namespace GeometryCalculatorWebApp.Controllers
{
    // Kontroler obs�uguj�cy ��dania dotycz�ce kalkulacji geometrycznych
    public class GeometryController : Controller
    {
        // Metoda obs�uguj�ca ��dania GET na �cie�ce /Geometry/Index
        [HttpGet]
        public IActionResult Index()
        {
            // Zwraca widok Index.cshtml
            return View();
        }

        // Metoda obs�uguj�ca ��dania POST na �cie�ce /Geometry/Calculate
        [HttpPost]
        public IActionResult Calculate([FromBody] ShapeModel model)
        {
            // Obliczanie r�nych w�a�ciwo�ci prostok�ta na podstawie modelu
            double area = model.CalculateArea();
            double perimeter = model.CalculatePerimeter();
            double diagonal = model.CalculateDiagonal();
            double totalEdgeLength = model.CalculateTotalEdgeLength();

            // Tworzenie obiektu wynikowego zawieraj�cego obliczone warto�ci
            var result = new
            {
                Area = area,
                Perimeter = perimeter,
                Diagonal = diagonal,
                TotalEdgeLength = totalEdgeLength
            };

            // Zwracanie wynik�w w formacie JSON do klienta
            return Json(result);
        }
    }
}