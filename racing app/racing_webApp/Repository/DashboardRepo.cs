﻿using racing_webApp.Data;
using racing_webApp.Extensions;
using racing_webApp.Inerfaces;
using racing_webApp.Models;

namespace racing_webApp.Repository
{
    public class DashboardRepo : IDashboardRepo
    {
        private readonly Db_context _context;
        private readonly IHttpContextAccessor _httpContextAccesor;

        public DashboardRepo(Db_context context,IHttpContextAccessor httpContextAccesor) 
        {
            _context = context;
            _httpContextAccesor = httpContextAccesor;
        }
        public async Task<List<Club>> GetAllUserClubs()
        {
            var currentUser = _httpContextAccesor.HttpContext.User.GetUserIDAccessor();
            var userClubs = _context.Clubs.Where(r => r.AppUserId == currentUser);
            return userClubs.ToList();
        }

        public async Task<List<Race>> GetAllUserRaces()
        {
            var currentUser = _httpContextAccesor.HttpContext?.User.GetUserIDAccessor();
            var userRaces = _context.Races.Where(r => r.AppUser.Id == currentUser);
            return userRaces.ToList();
        }
    }
}
