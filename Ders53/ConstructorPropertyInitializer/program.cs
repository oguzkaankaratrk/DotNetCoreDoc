Person person = new Person { FirstName = "ali", LastName = "kılç", City = "kütahya" };

//constructor - property init order = önce ctor çalışır, sonra initializerdeki proplar sırayla set edilir.
Dog dog = new Dog(3) { Name = "fino" };