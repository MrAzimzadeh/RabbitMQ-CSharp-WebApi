using DDormulaAirline.API.Models;
using DDormulaAirline.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace DDormulaAirline.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BookingsController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IMassageProducer _messageProducer;
    private  static readonly List<Booking> _bookings = new();

    public BookingsController(ILogger<WeatherForecastController> logger, IMassageProducer messageProducer)
    {
        _logger = logger;
        _messageProducer = messageProducer;
    }
    [HttpPost]
    public IActionResult CreatingBooking(Booking newBooking)
    {
        if (!ModelState.IsValid) return BadRequest();
        _bookings.Add(newBooking);
        _messageProducer.SendingMessage<Booking>(newBooking);
        return Ok();

    }

}
