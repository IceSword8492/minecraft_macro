#r "System.Windows.Forms"

#load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\mouse.csx"
#load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\keyboard.csx"
#load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\slot.csx"

using System.Windows.Forms;

class HotPotatoBook {
    public static async void execute () {
        int craftDelay = 250;
        int buyDelay = 1000;


        await Task.Delay(1000);
        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 31; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[25]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);


        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 29; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft exA
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move_item_to_eChest
        Key.Press('E');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(1069, 493);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Mouse.SetCursorPosition(816,647); // ech_0
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Mouse.SetCursorPosition(814, 546); // ech_ech
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Mouse.SetCursorPosition(851, 645); // ech_1
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Mouse.SetCursorPosition(816, 647); // ech_0
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft exA
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move_item_to_eChest
        Key.Press('E');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(1069, 493);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Mouse.SetCursorPosition(816,647); // ech_0
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Mouse.SetCursorPosition(850, 550); // ech_ech
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Mouse.SetCursorPosition(851, 645); // ech_1
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Mouse.SetCursorPosition(816, 647); // ech_0
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 30; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                Mouse.SetCursorPosition(Slot.CraftInventory[i * 5 + j + 1]);
                await Task.Delay(craftDelay);
                Mouse.ClickL();
                await Task.Delay(craftDelay);
            }
            Mouse.SetCursorPosition(Slot.CraftCrafted);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftInventory[26]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);

        // buy
        Key.Press('8');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[2]);
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.Shop[12]);
        await Task.Delay(500);
        for (int i = 0; i < 10; i++) {
            Mouse.ClickL();
            await Task.Delay(buyDelay);
        }
        Key.Press('E');
        await Task.Delay(500);
        // move A
        Key.Down('S');
        Key.Down('D');
        await Task.Delay(1000);
        Key.Up('S');
        Key.Up('D');
        await Task.Delay(500);
        // craft
        Key.Press('9');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        for (int j = 1; j < 6; j++) {
            Mouse.SetCursorPosition(Slot.CraftInventory[j]);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
        }
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[6]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[31]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[32]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        // craft_ebpotato
        Key.Press('E');
        await Task.Delay(500);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(1069, 493);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        Mouse.SetCursorPosition(810, 550); // ech_ech
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Mouse.SetCursorPosition(850, 550); // ech_ech
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Up(Key.Shift);
        await Task.Delay(500);
        Key.Press('E');
        await Task.Delay(craftDelay);
        Mouse.ClickR();
        await Task.Delay(500);
        Mouse.SetCursorPosition(960, 528);
        await Task.Delay(500);
        Mouse.ClickL();
        await Task.Delay(500);
        Key.Down(Key.Shift);
        await Task.Delay(500);
        Mouse.SetCursorPosition(Slot.CraftInventory[0]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[33]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftInventory[34]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.Craft9x9[0]);
        await Task.Delay(craftDelay);
        Mouse.ClickR();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.Craft9x9[3]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.Craft9x9[1]);
        await Task.Delay(craftDelay);
        Mouse.ClickR();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.Craft9x9[4]);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(Slot.CraftCrafted);
        await Task.Delay(craftDelay);
        Key.Down(Key.Shift);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Key.Up(Key.Shift);
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(960, 600);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(1067, 491);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(958, 764);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        Mouse.SetCursorPosition(817, 579);
        await Task.Delay(craftDelay);
        Mouse.ClickL();
        await Task.Delay(craftDelay);
        // move B
        Key.Press('E');
        await Task.Delay(500);
        Key.Down('A');
        await Task.Delay(1000);
        Key.Up('A');
        await Task.Delay(500);
    }
}

HotPotatoBook.execute();