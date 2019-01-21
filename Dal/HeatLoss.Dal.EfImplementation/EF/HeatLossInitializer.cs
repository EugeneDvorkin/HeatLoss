using System.Data.Entity;
using HeatLoss.Dal.Common.Entity.OvergroundLaying.CanalLaying;
using HeatLoss.Dal.Common.Entity.UndergroundLaying;

namespace HeatLoss.Dal.EfImplementation.EF
{
    public class HeatLossInitializer : DropCreateDatabaseIfModelChanges<HeatLossContext>
    {
        protected override void Seed(HeatLossContext context)
        {
            UndergroundLayingSet(context);
            OvergroundCanalSet(context);
        }

        private void UndergroundLayingSet(HeatLossContext context)
        {
            context.UndergroundLaying.AddRange(new[]
            {
                new UndergroundLaying
                {
                    Id = 1,
                    Dp = 32,
                    Dk = 32,
                    Qk = 36,
                    Q110 = 42,
                    Q145 = 53,
                    Q195 = 72,
                    Q245 = 90,
                    Q295 = 108,
                    Q345 = 126,
                    Q395 = 144,
                    Q445 = 163
                },
                new UndergroundLaying
                {
                    Id = 2,
                    Dp = 38,
                    Dk = 32,
                    Qk = 36,
                    Q110 = 45,
                    Q145 = 58,
                    Q195 = 78,
                    Q245 = 98,
                    Q295 = 115,
                    Q345 = 133,
                    Q395 = 152,
                    Q445 = 172
                },
                new UndergroundLaying
                {
                    Id = 3,
                    Dp = 45,
                    Dk = 32,
                    Qk = 36,
                    Q110 = 49,
                    Q145 = 62,
                    Q195 = 84,
                    Q245 = 105,
                    Q295 = 126,
                    Q345 = 145,
                    Q395 = 167,
                    Q445 = 188
                },
                new UndergroundLaying
                {
                    Id = 4,
                    Dp = 57,
                    Dk = 32,
                    Qk = 36,
                    Q110 = 52,
                    Q145 = 67,
                    Q195 = 91,
                    Q245 = 112,
                    Q295 = 134,
                    Q345 = 156,
                    Q395 = 178,
                    Q445 = 201
                },
                new UndergroundLaying
                {
                    Id = 5,
                    Dp = 76,
                    Dk = 38,
                    Qk = 39.5,
                    Q110 = 58,
                    Q145 = 77,
                    Q195 = 100,
                    Q245 = 126,
                    Q295 = 149,
                    Q345 = 172,
                    Q395 = 198,
                    Q445 = 221
                },
                new UndergroundLaying
                {
                    Id = 6,
                    Dp = 89,
                    Dk = 45,
                    Qk = 42,
                    Q110 = 65,
                    Q145 = 83,
                    Q195 = 108,
                    Q245 = 133,
                    Q295 = 158,
                    Q345 = 184,
                    Q395 = 209,
                    Q445 = 235
                },
                new UndergroundLaying
                {
                    Id = 7,
                    Dp = 108,
                    Dk = 45,
                    Qk = 42,
                    Q110 = 72,
                    Q145 = 90,
                    Q195 = 117,
                    Q245 = 145,
                    Q295 = 172,
                    Q345 = 200,
                    Q395 = 215,
                    Q445 = 254
                },
                new UndergroundLaying
                {
                    Id = 8,
                    Dp = 133,
                    Dk = 57,
                    Qk = 46.5,
                    Q110 = 79,
                    Q145 = 99,
                    Q195 = 129,
                    Q245 = 158,
                    Q295 = 188,
                    Q345 = 219,
                    Q395 = 247,
                    Q445 = 278
                },
                new UndergroundLaying
                {
                    Id = 9,
                    Dp = 159,
                    Dk = 76,
                    Qk = 52,
                    Q110 = 86,
                    Q145 = 109,
                    Q195 = 140,
                    Q245 = 172,
                    Q295 = 204,
                    Q345 = 238,
                    Q395 = 267,
                    Q445 = 302
                },
                new UndergroundLaying
                {
                    Id = 10,
                    Dp = 194,
                    Dk = 89,
                    Qk = 58,
                    Q110 = 95,
                    Q145 = 120,
                    Q195 = 151,
                    Q245 = 188,
                    Q295 = 223,
                    Q345 = 259,
                    Q395 = 291,
                    Q445 = 326
                },
                new UndergroundLaying
                {
                    Id = 11,
                    Dp = 219,
                    Dk = 89,
                    Qk = 58,
                    Q110 = 102,
                    Q145 = 128,
                    Q195 = 163,
                    Q245 = 204,
                    Q295 = 242,
                    Q345 = 279,
                    Q395 = 314,
                    Q445 = 351
                },
                new UndergroundLaying
                {
                    Id = 12,
                    Dp = 273,
                    Dk = 108,
                    Qk = 64,
                    Q110 = 116,
                    Q145 = 145,
                    Q195 = 186,
                    Q245 = 230,
                    Q295 = 271,
                    Q345 = 312,
                    Q395 = 355,
                    Q445 = 395
                },
                new UndergroundLaying
                {
                    Id = 13,
                    Dp = 325,
                    Dk = 133,
                    Qk = 70,
                    Q110 = 130,
                    Q145 = 163,
                    Q195 = 209,
                    Q245 = 256,
                    Q295 = 329,
                    Q345 = 379,
                    Q395 = 430,
                    Q445 = 477
                },
                new UndergroundLaying
                {
                    Id = 14,
                    Dp = 377,
                    Dk = 159,
                    Qk = 75.5,
                    Q110 = 146.5,
                    Q145 = 181,
                    Q195 = 231,
                    Q245 = 279,
                    Q295 = 329,
                    Q345 = 379,
                    Q395 = 430,
                    Q445 = 477
                },
                new UndergroundLaying
                {
                    Id = 15,
                    Dp = 426,
                    Dk = 194,
                    Qk = 85,
                    Q110 = 164,
                    Q145 = 201,
                    Q195 = 254,
                    Q245 = 302,
                    Q295 = 356,
                    Q345 = 409,
                    Q395 = 463,
                    Q445 = 512
                },
                new UndergroundLaying
                {
                    Id = 16,
                    Dp = 476,
                    Dk = 219,
                    Qk = 91,
                    Q110 = 176,
                    Q145 = 215,
                    Q195 = 273,
                    Q245 = 326,
                    Q295 = 384,
                    Q345 = 436,
                    Q395 = 488,
                    Q445 = 547
                },
                new UndergroundLaying
                {
                    Id = 17,
                    Dp = 529,
                    Dk = 273,
                    Qk = 101,
                    Q110 = 186,
                    Q145 = 228,
                    Q195 = 285,
                    Q245 = 349,
                    Q295 = 407,
                    Q345 = 465,
                    Q395 = 523,
                    Q445 = 582
                },
                new UndergroundLaying
                {
                    Id = 18,
                    Dp = 630,
                    Dk = 325,
                    Qk = 116,
                    Q110 = 208,
                    Q145 = 254,
                    Q195 = 320,
                    Q245 = 384,
                    Q295 = 448,
                    Q345 = 512,
                    Q395 = 582,
                    Q445 = 645
                },
                new UndergroundLaying
                {
                    Id = 19,
                    Dp = 720,
                    Dk = 325,
                    Qk = 116,
                    Q110 = 226,
                    Q145 = 277,
                    Q195 = 345,
                    Q245 = 416,
                    Q295 = 488,
                    Q345 = 558,
                    Q395 = 630,
                    Q445 = 700
                },
                new UndergroundLaying
                {
                    Id = 20,
                    Dp = 820,
                    Dk = 325,
                    Qk = 116,
                    Q110 = 256,
                    Q145 = 309,
                    Q195 = 384,
                    Q245 = 463,
                    Q295 = 540,
                    Q345 = 622,
                    Q395 = 698,
                    Q445 = 773
                }
            });
        }

        private void OvergroundCanalSet(HeatLossContext context)
        {
            context.OvergroundCanalLaying.AddRange(new[]
            {
                new OvergroundCanalLaying
                {
                    Id = 1,
                    D = 48,
                    Q10 = 15,
                    Q60 = 27,
                    Q160 = 64,
                    Q260 = 109,
                    Q360 = 155
                },
                new OvergroundCanalLaying
                {
                    Id = 2,
                    D = 57,
                    Q10 = 17,
                    Q60 = 31,
                    Q160 = 69,
                    Q260 = 116,
                    Q360 = 164
                },
                new OvergroundCanalLaying
                {
                    Id = 3,
                    D = 76,
                    Q10 = 19,
                    Q60 = 36,
                    Q160 = 78,
                    Q260 = 130,
                    Q360 = 183
                },
                new OvergroundCanalLaying
                {
                    Id = 4,
                    D = 89,
                    Q10 = 21,
                    Q60 = 39,
                    Q160 = 85,
                    Q260 = 140,
                    Q360 = 195
                },
                new OvergroundCanalLaying
                {
                    Id = 5,
                    D = 108,
                    Q10 = 23,
                    Q60 = 44,
                    Q160 = 92,
                    Q260 = 152,
                    Q360 = 212
                },
                new OvergroundCanalLaying
                {
                    Id = 6,
                    D = 133,
                    Q10 = 27,
                    Q60 = 49,
                    Q160 = 102,
                    Q260 = 167,
                    Q360 = 233
                },
                new OvergroundCanalLaying
                {
                    Id = 7,
                    D = 159,
                    Q10 = 30,
                    Q60 = 55,
                    Q160 = 113,
                    Q260 = 183,
                    Q360 = 255
                },
                new OvergroundCanalLaying
                {
                    Id = 8,
                    D = 219,
                    Q10 = 36,
                    Q60 = 67,
                    Q160 = 135,
                    Q260 = 216,
                    Q360 = 297
                },
                new OvergroundCanalLaying
                {
                    Id = 9,
                    D = 273,
                    Q10 = 42,
                    Q60 = 75,
                    Q160 = 149,
                    Q260 = 237,
                    Q360 = 317
                },
                new OvergroundCanalLaying
                {
                    Id = 10,
                    D = 325,
                    Q10 = 48,
                    Q60 = 85,
                    Q160 = 165,
                    Q260 = 264,
                    Q360 = 351
                },
                new OvergroundCanalLaying
                {
                    Id = 11,
                    D = 377,
                    Q10 = 53,
                    Q60 = 94,
                    Q160 = 181,
                    Q260 = 288,
                    Q360 = 386
                },
                new OvergroundCanalLaying
                {
                    Id = 12,
                    D = 426,
                    Q10 = 58,
                    Q60 = 102,
                    Q160 = 199,
                    Q260 = 314,
                    Q360 = 412
                },
                new OvergroundCanalLaying
                {
                    Id = 13,
                    D = 478,
                    Q10 = 63,
                    Q60 = 110,
                    Q160 = 208,
                    Q260 = 334,
                    Q360 = 440
                },
                new OvergroundCanalLaying
                {
                    Id = 14,
                    D = 529,
                    Q10 = 68,
                    Q60 = 118,
                    Q160 = 228,
                    Q260 = 359,
                    Q360 = 472
                },
                new OvergroundCanalLaying
                {
                    Id = 15,
                    D = 630,
                    Q10 = 79,
                    Q60 = 134,
                    Q160 = 256,
                    Q260 = 396,
                    Q360 = 520
                },
                new OvergroundCanalLaying
                {
                    Id = 16,
                    D = 720,
                    Q10 = 88,
                    Q60 = 149,
                    Q160 = 281,
                    Q260 = 436,
                    Q360 = 574
                },
                new OvergroundCanalLaying
                {
                    Id = 17,
                    D = 820,
                    Q10 = 99,
                    Q60 = 165,
                    Q160 = 310,
                    Q260 = 492,
                    Q360 = 645
                },
                new OvergroundCanalLaying
                {
                    Id = 18,
                    D = 920,
                    Q10 = 107,
                    Q60 = 184,
                    Q160 = 340,
                    Q260 = 531,
                    Q360 = 686
                },
                new OvergroundCanalLaying
                {
                    Id = 19,
                    D = 1020,
                    Q10 = 116,
                    Q60 = 198,
                    Q160 = 364,
                    Q260 = 563,
                    Q360 = 753
                }
            });
        }
    }
}