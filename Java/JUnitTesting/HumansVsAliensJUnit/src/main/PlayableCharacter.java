package main;

public class PlayableCharacter {
	public int health;
	public String name;
	public int attackPower;
		
	public PlayableCharacter(int hp, String name, int ap) {
		this.health = hp;
		this.name = name;
		this.attackPower = ap;
		
	}

	public int takeDamage(int damage) {
		this.health -= damage;
		if(this.health <= 0) {
			this.health = 0;
			System.out.println("Character has died");
		}
		return this.health;
	}
	
	public double dealDamage() {
		double damage = this.attackPower;
		return damage;
	}
	
	//@Overload
	public double dealDamage(double weaponDmgBonus) {
		double damage = this.attackPower * weaponDmgBonus;
		return damage += this.attackPower;
	}
	
	public double useWeaponOrItem(double dmgModifier) {
		this.attackPower += this.attackPower * dmgModifier;
		return this.attackPower;
	}
	
	public int getHealth() {
		return this.health;
	}
	
	public String getName() {
		return this.name;
	}
	
	public int getAttackPower() {
		return this.attackPower;
	}
	
	
}