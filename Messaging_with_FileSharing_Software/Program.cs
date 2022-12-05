using Messaging_with_FileSharing_Software.MessageHub;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR();
var app = builder.Build();
app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.MapHub<MessageWithFileSharingHub>("/messageWithFileSharingHub");
app.Run();
