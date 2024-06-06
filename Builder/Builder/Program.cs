using Builder;

Director carDirector = new Director();
DaewooLanosBuilder daewooLanosBuilder = new DaewooLanosBuilder();
FordProbeBuilder fordProbeBuilder = new FordProbeBuilder();
UAZPatriotBuilder uAZPatriotBuilder = new UAZPatriotBuilder();
HyundaiGetzBuilder hyundaiGetzBuilder = new HyundaiGetzBuilder();
carDirector.BuildCar(daewooLanosBuilder);
carDirector.BuildCar(fordProbeBuilder);
carDirector.BuildCar(uAZPatriotBuilder);
carDirector.BuildCar(hyundaiGetzBuilder);