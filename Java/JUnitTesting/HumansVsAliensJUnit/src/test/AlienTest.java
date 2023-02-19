package test;

import static org.junit.Assert.*;

import org.junit.Test;

import main.Alien;

public class AlienTest {
	Alien alienJD = new Alien(100, "JD", 100);
	
	@Test
	public void testAlienInstatiation() {
		assertEquals(100, alienJD.getHealth());
		assertEquals("JD", alienJD.getName());
		assertEquals(100, alienJD.getAttackPower());
	}
	
	@Test
	public void testAlienPowerup() {
		assertEquals(135, alienJD.useAlienPowerup(), 1);
	}
	
	@Test
	public void testAlienWeapon1() {
		assertEquals(115, alienJD.useAlienWeapon(15), 1);
	}
	
	@Test
	public void testAlienWeapon2() {
		assertEquals(105, alienJD.useAlienWeapon(5), 1);
	}
	
	@Test
	public void testMutate() {
		alienJD.mutate();
		assertEquals(85, alienJD.getHealth(), 1);
		assertEquals(120, alienJD.getAttackPower(), 1);
		
	}
	
	

}
