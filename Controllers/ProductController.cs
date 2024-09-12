using Microsoft.AspNetCore.Mvc;
using CheckNSell.Data;

namespace CheckNSell.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    // สร้าง Object ของ ApplicationDbContext
    private readonly ApplicationDbContext _context;

    // สร้าง Constructor รับค่า ApplicationDbContext
    public ProductController(ApplicationDbContext context)
    {
        _context = context;
    }

    // ทดสอบเขียนฟังก์ชันการเชื่อมต่อ database
    // GET: /api/Product/testconnectdb
    [HttpGet("testconnectdb")]
    public void TestConnection()
    {
        // ถ้าเชื่อมต่อได้จะแสดงข้อความ "Connected"
        if (_context.Database.CanConnect())
        {
            Response.WriteAsync("Connected");
        }
        // ถ้าเชื่อมต่อไม่ได้จะแสดงข้อความ "Not Connected"
        else
        {
            Response.WriteAsync("Not Connected");
        }
    }
}