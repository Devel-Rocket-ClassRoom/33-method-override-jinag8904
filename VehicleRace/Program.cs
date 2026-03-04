using System;

Vehicle[] vehicles =
{
    new Car { Name = "스포츠카" },
    new Airplane { Name = "보잉747" },
    new Boat { Name = "요트" }
};

foreach (var vehicle in vehicles)
{
    vehicle.Move();
}