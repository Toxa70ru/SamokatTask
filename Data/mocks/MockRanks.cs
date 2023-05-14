using SamokatTask.Data.Interfaces;
using SamokatTask.Data.Models;
using System.Data;

namespace SamokatTask.Data.mocks
{
    public class MockRanks : IRank
    {
        public IEnumerable<Rank> ranks {
            get {
                return new List<Rank> {
                    new Rank
                    {
                        Id = 1,
                        Img = "",
                        Name = "Иванов Иван Иванович",
                        Level = 9
                    },
                    new Rank
                    {
                        Id = 2,
                        Img = "",
                        Name = "Сидоров Сегрей Сергеевич",
                        Level = 8
                    },
                    new Rank
                    {
                        Id = 3,
                        Img = "",
                        Name = "Хавелев Илья Викторович",
                        Level = 7
                    },
                    new Rank
                    {
                        Id = 4,
                        Img = "",
                        Name = "Даниленко Фёдор Андреевич",
                        Level= 6
                    },
                    new Rank
                    {
                        Id = 5,
                        Img = "",
                        Name = "Базаев Роман Георгиевич",
                        Level= 5
                    }
                };
            }
        }
    }
}
