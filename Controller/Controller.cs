﻿using Domain;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Implementations;

namespace ControllerClass
{
    public class Controller
    {

        private static Controller instance;

        private Controller() 
        {
            this.repositorySluzbenikAutoSkole = new RepositorySluzbenikAutoSkole(); 
        }

        public static Controller Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controller();
                return instance;
            }
        }

        private IRepositorySluzbenikAutoSkole repositorySluzbenikAutoSkole;
        private IRepositoryPolaznik repositoryPolaznik;
        private IRepositoryInstruktor repositoryInstruktor;
        
        public SluzbenikAutoSkole SluzbenikAutoSkole { get; set; }


        public bool Prijavljivanje(SluzbenikAutoSkole sluzbenik)
        {
            return repositorySluzbenikAutoSkole.Prijavljivanje(sluzbenik);
        }

    }
}
