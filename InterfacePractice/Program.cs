using InterfacePracticeCore.Classes.Characters;
using InterfacePracticeCore.Classes.Weapons;
using InterfacePracticeCore.Interfaces;

Pistol pistol = new Pistol();
Baton baton = new Baton();
AutomaticRifle ak47 = new AutomaticRifle();
Shuriken shuriken = new Shuriken();
Knife knife = new Knife();

Engineer Roma = new Engineer();
Shooter Sasha = new Shooter();

Sasha.PickUpWeapon(ak47);
Sasha.PickUpWeapon(pistol);
Sasha.UseAllWeaponsFromInventory();

Sasha.HitMelee(knife);
Sasha.ThrowMelee(knife);

Sasha.ThrowMelee(shuriken);

Sasha.HitMelee(baton);

Roma.Repair(ak47);
Roma.Repair(pistol);
Roma.Repair(shuriken);
Roma.Repair(knife);

Roma.Upgrade(knife);

