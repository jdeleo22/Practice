package main;

public class Environment {

	
	//Environment out of Cell objects. A Cell would be a class object created that will populate Environment
	//calculate distance between populated cell objects--distance would effect damage values for weapons
	//cells can also track weapons on floor to pickup and use on PC objects
	
	public static void main(String[] args) {
	
		Object[] environment = new Object[10];
		//hp-name-ap
		environment[0] = new Human(100, "JD", 100);
		environment[0] = new Alien(100, "Alien1", 100);

	}

}
