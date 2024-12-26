using System;
using Laba4;
namespace Laba4Tests

{
	public class UtilsTest
	{
		[Fact]
		public void TestCalculateAge()
		{
			Person person = new Person();
			person.Birthday = new DateTime(2000, 1, 1);


			int actual = Utils.CalculateAge(person);
			Assert.Equal(24, actual);

		}




		[Fact]
		public void TestStringGeneration()
		{

			var person = new Person()
			{
				Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
				Name = "Karina",
				SurName = "Kolodov",
				Age = 42,
				Birthday = DateTime.Parse("1981-08-12"),
				IsAdmin = false
			};



			string expected = "12 августа: Karina Kolodov - исполнится 43";
			string actual = Utils.FormaBirthdayString(person);


			Assert.Equal(expected, actual);

		}

		[Fact]
		public void TestFileGeneration()
		{
			List<Person> person = new List<Person>();

			{
				new Person()
				{
					Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
					Name = "Jhon",
					SurName = "Kolesov",
					Age = 37,
					Birthday = DateTime.Parse("1986-05-11T00:00:00"),
					IsAdmin = false
				};

				new Person()
				{
					Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
					Name = "Karina",
					SurName = "Orlova",
					Age = 26,
					Birthday = DateTime.Parse("1997-03-04T11:56:25.496732+06:00"),
					IsAdmin = false
				};

				new Person()
				{
					Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
					Name = "Marina",
					SurName = "Lirina",
					Age = 15,
					Birthday = DateTime.Parse("2008-02-09T11:56:25.4967308+06:00"),
					IsAdmin = false
				};
			}
			MemoryStream stream = new MemoryStream();
			StreamWriter writer = new StreamWriter(stream);


			string expected = "09 февраля: Marina Lirina - исполнится 16\r\n" +
							  "04 марта: Karina Orlova - исполнится 27\r\n" +
							  "11 мая: Jhon Kolesov - исполнится 38\r\n";

            Utils.SortingRecording(person, writer);

			writer.Flush();

            stream.Seek(0, SeekOrigin.Begin);

			StreamReader reader = new StreamReader(stream);
            string actual = reader.ReadToEnd();


            Assert.Equal(expected, actual);
		}


        [Fact]
        public void TestBinarySerialize()
        {

			const string inputFilePath = @"D:\ВКИ\5 семестр\Разработка программных модулей\Laba4\Laba4\People.json";
            const string outputFilePath = @"D:\ВКИ\5 семестр\Разработка программных модулей\Laba4\Laba4\Person.bin";
            
			List<Person> person = new List<Person>();

			{
				new Person()
				{
					Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
					Name = "Jhon",
					SurName = "Kolesov",
					Age = 37,
					Birthday = DateTime.Parse("1986-05-11T00:00:00"),
					IsAdmin = false
				};

				new Person()
				{
					Id = Guid.Parse("e1ed8d1a-9a22-4d56-b3a0-b9eb87c33a58"),
					Name = "Karina",
					SurName = "Orlova",
					Age = 26,
					Birthday = DateTime.Parse("1997-03-04T11:56:25.496732+06:00"),
					IsAdmin = false
				};
			}


            PersonBinarySerializer.BinarySerialize(inputFilePath, outputFilePath);

            List<Person> deserializedPeople = PersonBinarySerializer.BinaryDeserialize(outputFilePath);

            Assert.Equal(person, deserializedPeople);

        }
    }
}
