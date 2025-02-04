﻿using Arctic.Puzzlers.Objects.CompetitionObjects;

namespace Arctic.Puzzlers.Parsers.CompetitionParsers
{
    internal static class CompetitionRoundExtensions
    {
        internal static void SetContestType(this CompetitionRound competitionObject)
        {
            if (competitionObject.Participants.All(t => t.Participants.Count <= 1))
            {
                competitionObject.ContestType = ContestType.Individual;
            }
            else if (competitionObject.Participants.All(t => t.Participants.Count <= 2))
            {
                competitionObject.ContestType = ContestType.Pairs;
            }
            else if (competitionObject.Participants.All(t => t.Participants.Count <= 4))
            {
                competitionObject.ContestType = ContestType.Teams;
            }
            else
            {
                competitionObject.ContestType = ContestType.Unknown;
            }
        }
      
    }
}
