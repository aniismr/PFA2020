using System;
using System.Collections.Generic;
using PFA.Models;

namespace PFA.Service
{
    public interface ICandidatService
    {
        public List<Candidat> GetCandidats();

        public Candidat AddCandidat(Candidat c);

        public Candidat UpdateCandidat(int id, Candidat c);

        public int DeleteCandidat(int id);
    }
}