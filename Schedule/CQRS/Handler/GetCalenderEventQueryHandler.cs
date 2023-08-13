using Project.Models;

namespace Project.CQRS.Handler
{
    public class GetCalenderEventQueryHandler
    {
        private readonly CalendarDbContext _context;

        public GetCalenderEventQueryHandler(CalendarDbContext context)
        {
            _context = context;
        }


        public List<CalendarEvent> Handle(DateTime start, DateTime end)
        {
            var values = _context.Events
                   .Where(e => !((e.End <= start) || (e.Start >= end)))
                   .ToList();
            return values;
        }
    }
}
