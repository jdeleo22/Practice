package test;

import static org.junit.Assert.*;

import org.junit.Test;

import main.Human;

public class HumanTest {
		Human jd = new Human(100, "JD", 100);
	@Test
	public void testHumanInstantiation() {
		
		assertEquals(100, jd.getHealth());
		assertEquals("JD", jd.getName());
		assertEquals(100, jd.getAttackPower());
		assertEquals(0, jd.getArmor());
	}
	
	@Test 
	public void testUsePerceptionAbility() {
		assertEquals(120, jd.usePerceptionAbility(), 1);
	}
	
	@Test 
	public void testUseArmor() {
		assertEquals(20, jd.useArmor(), 1);
	}
	@Test 
	public void testEatFood() {
		assertEquals(110, jd.eatFood(), 1);
	}

}
