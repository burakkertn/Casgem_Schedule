using Project.Models;

namespace Project.CQRS.Handler
{
    public class CreateCalenderEventCommandHandler
    {
        private readonly CalendarDbContext _context;

        public CreateCalenderEventCommandHandler(CalendarDbContext context)
        {
            _context = context;
        }
        public void Handle(CalendarEvent calendarEvent)
        {
            _context.Events.Add(new CalendarEvent
            {
                Color = calendarEvent.Color,
                End = calendarEvent.End,
                Start = calendarEvent.Start,
                Text = calendarEvent.Text
            });
            _context.SaveChanges();
        }
    }
}
