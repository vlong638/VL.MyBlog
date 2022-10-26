namespace VL.BlazorApp.Data
{
    public class StoryService
    {
        private static readonly List<Story> Stories = new List<Story>()
        {
            new Story (){
                Id = 1,
                Name = "我是传奇工匠",
                Chapters = new List<Chapter>()
                {
                    new Chapter(){
                        Id= 1,
                        Name ="第一章 新世界",
                        Sections = new List<Section>
                        {
                            new Section(){
                                Id = 1,
                                Name="第一节 欢迎来到酒馆",
                                Paragragh = "酒馆顿时骚乱了起来\r\n场面一片混乱"
                            },
                            new Section(){
                                Id = 2,
                                Name="第二节 举起锤子",
                                Paragragh = "举起锤子\r\n举起锤子"
                            }
                        }
                    },
                    new Chapter(){
                        Id= 1,
                        Name ="第二章 神话之战",
                        Sections = new List<Section>
                        {
                            new Section(){
                                Id = 1,
                                Name="第一节 敲黑板",
                                Paragragh = "酒馆顿时骚乱了起来\r\n场面一片混乱"
                            },
                            new Section(){
                                Id = 2,
                                Name="第二节 全军出击",
                                Paragragh = "举起锤子\r\n举起锤子"
                            },
                            new Section(){
                                Id = 3,
                                Name="第一百节 胜利",
                                Paragragh = "举起锤子\r\n举起锤子"
                            }
                        }
                    }
                }
            }
        };
        public Task<string[]> GetStoriesAsync()
        {

            return Task.FromResult(Stories.Select(c => c.Name).ToArray());
        }

        /// <summary>
        /// Chapter 章
        /// Section 节
        /// Paragragh 段落
        /// </summary>
        /// <returns></returns>
        public Task<List<Chapter>> GetChapters(long storyId)
        {

            return Task.FromResult(Stories.First().Chapters.ToList());
        }
    }

    public class Story
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
    public class Chapter
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Section> Sections { get; set; }
    }
    public class Section
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Paragragh { set; get; }
    }
}