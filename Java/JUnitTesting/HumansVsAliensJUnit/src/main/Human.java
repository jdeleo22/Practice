package main;

public class Human extends PlayableCharacter{
	int armorValue;
	
	
	public Human(int hp, String name, int ap) {
		super(hp, name, ap);
		
	}
	
	public double usePerceptionAbility() {
		this.attackPower += this.attackPower * .20;
		return this.attackPower;
	}
	
	public double useArmor() {
		return this.armorValue += 20;
	}
	
	public double eatFood() {
		return this.attackPower += this.attackPower * .10;
	}

	public int getArmor() {
		return this.armorValue;
	}
}
