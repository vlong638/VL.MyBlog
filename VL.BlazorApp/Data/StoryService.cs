namespace VL.BlazorApp.Data
{
    public class StoryService
    {
        private static readonly List<Story> Stories = new List<Story>()
        {
            new Story (){
                Id = 1,
                Name = "���Ǵ��湤��",
                Chapters = new List<Chapter>()
                {
                    new Chapter(){
                        Id= 1,
                        Name ="��һ�� ������",
                        Sections = new List<Section>
                        {
                            new Section(){
                                Id = 1,
                                Name="��һ�� ��ӭ�����ƹ�",
                                Paragragh = "�ƹݶ�ʱɧ��������\r\n����һƬ����"
                            },
                            new Section(){
                                Id = 2,
                                Name="�ڶ��� ������",
                                Paragragh = "������\r\n������"
                            }
                        }
                    },
                    new Chapter(){
                        Id= 1,
                        Name ="�ڶ��� ��֮ս",
                        Sections = new List<Section>
                        {
                            new Section(){
                                Id = 1,
                                Name="��һ�� �úڰ�",
                                Paragragh = "�ƹݶ�ʱɧ��������\r\n����һƬ����"
                            },
                            new Section(){
                                Id = 2,
                                Name="�ڶ��� ȫ������",
                                Paragragh = "������\r\n������"
                            },
                            new Section(){
                                Id = 3,
                                Name="��һ�ٽ� ʤ��",
                                Paragragh = "������\r\n������"
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
        /// Chapter ��
        /// Section ��
        /// Paragragh ����
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