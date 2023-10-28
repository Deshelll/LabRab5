using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Test2;

[Route("api/files")]
[ApiController]
public class FilesController : ControllerBase
{
    private readonly AppDbContext _context;

    public FilesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetFiles()
    {
        var files = await _context.Files.ToListAsync();
        return Ok(files);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetFile(int id)
    {
        var file = await _context.Files.FindAsync(id);
        if (file == null)
        {
            return NotFound();
        }
        return File(file.Data, file.ContentType, file.FileName);
    }

    [HttpPost]
    public async Task<IActionResult> UploadFile([FromForm] FileUploadModel fileUpload)
    {
        if (fileUpload == null || fileUpload.File == null || fileUpload.File.Length == 0)
        {
            return BadRequest("Файл не был загружен.");
        }

