using Microsoft.AspNetCore.Mvc;

namespace TestForEgoPaulus.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    public WeatherForecastController()
    {
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public Organ Get()
    {
        OrganRepository organRepository = new OrganRepository();

        return organRepository.GetOrgan();
    }

    [HttpPost]
    public Organ Save([FromBody] OrganDTO organDTO)
    {
        OrganRepository organRepository = new OrganRepository();

        return organRepository.Save(organDTO);
    }

    [HttpDelete]
    public string Delete([FromBody] OrganDTO organDTO)
    {
        OrganRepository organRepository = new OrganRepository();

        return organRepository.Delete();
    }
}
