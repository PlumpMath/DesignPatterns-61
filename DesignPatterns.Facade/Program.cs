using DesignPatterns.Facade.HomeTheater;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    /// <summary>
    /// The facade pattern provides a unified interface to a set of interfaces in a subsystem.
    /// Facade defines a higher-level interface that makes the subsystem easier to use.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var dvdPlayer = new DVDPlayer();
            var projector = new Projector();
            var screen = new Screen();
            var popcornPopper = new PopcornPopper();

            var homeTheaterFacade = new HomeTheaterFacade(dvdPlayer, projector, screen, popcornPopper);
            homeTheaterFacade.WatchMovie("Hercule Poirot");
            homeTheaterFacade.EndMovie();
            Console.ReadLine();
        }
    }
}
