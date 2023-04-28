using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using RegistroNotasApi.BusinessService;
using RegistroNotasApi.DataService;
using RegistroNotasApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddDbContext<Context>(opt => opt.UseInMemoryDatabase("Teacher"));
//builder.Services.AddDbContext<Context>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("connection_sql")));
builder.Services.AddDbContext<Context>(opt => opt.UseNpgsql(builder.Configuration.GetConnectionString("conection_pg")));

builder.Services.AddTransient<AlternativesDataService>();
builder.Services.AddTransient<AlternativesBusinessService>();

builder.Services.AddTransient<AnswerDataService>();
builder.Services.AddTransient<AnswerBusinessService>();

builder.Services.AddTransient<ChapterDataService>();
builder.Services.AddTransient<ChapterBusinessService>();

builder.Services.AddTransient<CourseDataService>();
builder.Services.AddTransient<CourseBusinessService>();

builder.Services.AddTransient<CourseRegistrationDataService>();
builder.Services.AddTransient<CourseRegistrationBusinessService>();

builder.Services.AddTransient<ExamDataService>();
builder.Services.AddTransient<ExamBusinessService>();

builder.Services.AddTransient<FacultadDataService>();
builder.Services.AddTransient<FacultadBusinessService>();

builder.Services.AddTransient<PSDataService>();
builder.Services.AddTransient<PSBusinessService>();

builder.Services.AddTransient<QuestionDataService>();
builder.Services.AddTransient<QuestionBusinessService>();
builder.Services.AddTransient<RegistrationDataService>();
builder.Services.AddTransient<RegistrationBusinessService>();
builder.Services.AddTransient<SemesterDataService>();
builder.Services.AddTransient<SemesterBusinessService>();
builder.Services.AddTransient<StudentDataService>();
builder.Services.AddTransient<StudentBusinessService>();
builder.Services.AddTransient<TeacherDataService>();
builder.Services.AddTransient<TeacherBusinessService>();
builder.Services.AddTransient<TeacherCourseDataService>();
builder.Services.AddTransient<TeacherCourseBusinessService>();

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
