using System;
using System.Collections.Generic;
using System.Linq;
using WC2018Notificator.Models;

namespace WC2018Notificator.Services
{
    public interface IPlayerService
    {
        void AddPlayer(Player model);
        void RemovePlayer(string id);

        IEnumerable<Player> GetPlayers();
    }

    public class PlayerService : IPlayerService
    {
        private List<Player> _players = new List<Player>();

        public void AddPlayer(Player model)
        {
            model.Id = Guid.NewGuid().ToString();

            _players.Add(model);
        }

        public IEnumerable<Player> GetPlayers()
        {
            return _players;
        }

        public void RemovePlayer(string id)
        {
            if(_players.FirstOrDefault(p => p.Id == id) != null)
            {
                _players.Remove(_players.First(p => p.Id == id));
            }
            
        }
    }
}
