package test;

import static org.junit.Assert.*;
import org.junit.Test;

import main.PlayableCharacter;

public class PlayableCharacterTest {
	
	PlayableCharacter pc = new PlayableCharacter(100, "JD", 100);

	@Test
	public void testPlayableCharacterInstantiation() {
		assertEquals(100, pc.getHealth());
		assertEquals("JD", pc.getName());
		assertEquals(100, pc.getAttackPower());
	
	}
	
	@Test
	public void testTakeDamage() {
		assertEquals(80, pc.takeDamage(20));
		assertEquals(0, pc.takeDamage(110));
	}
	
	@Test
	public void testDealDamage() {
		assertEquals(115, pc.dealDamage(.15), 1);
		assertEquals(100, pc.dealDamage(), 1);
	}
	
	@Test
	public void testUseWeaponOrItem20() {
		assertEquals(120, pc.useWeaponOrItem(.20), 1);
	}
	@Test
	public void testUseWeaponOrItem45() {
		assertEquals(145, pc.useWeaponOrItem(.45), 1);
	}

}
