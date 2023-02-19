package main;

public class Alien extends PlayableCharacter{

	public Alien(int hp, String name, int ap) {
		super(hp, name, ap);
		
	}
	
	double alienWeapon1 = 15;
	double alienWeapon2 = 5;
	
	
	public double useAlienPowerup() {
		this.attackPower += this.attackPower * .35;
		return this.attackPower;
	}
	
	public double useAlienWeapon(double weaponPower) {
		this.attackPower += this.attackPower * (.01 * (weaponPower));
		return this.attackPower;
	}
	
	public void mutate() {
		this.health -= 15;
		this.attackPower += 20;
		
	}

}
