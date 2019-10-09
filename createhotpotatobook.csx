#r "System.Windows.Forms"

#load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\mouse.csx"
#load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\keyboard.csx"
#load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\slot.csx"
// #load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\slot_note.csx"

using System.Windows.Forms;

class HotPotatoBook {
    public static async void execute () {
        int craftDelay = 250;
        int buyDelay = 1000;
        int loopCount = 1;

        for (int cnt = 0; cnt < loopCount; cnt++) {
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.EnderChest);
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_0); // ech_0
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_ech0); // ech_ech0
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_1); // ech_1
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_0); // ech_0
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.EnderChest);
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_0); // ech_0
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_ech1); // ech_ech1
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_1); // ech_1
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_0); // ech_0
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.EnderChest);
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Key.Down(Key.Shift);
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_ech0); // ech_ech
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.ech_ech1); // ech_ech
            await Task.Delay(500);
            Mouse.ClickL();
            await Task.Delay(500);
            Key.Up(Key.Shift);
            await Task.Delay(500);
            Key.Press('E');
            await Task.Delay(craftDelay);
            Mouse.ClickR();
            await Task.Delay(500);
            Mouse.SetCursorPosition(Slot.CraftTable);
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
            Mouse.SetCursorPosition(Slot.CraftGoBack);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
            Mouse.SetCursorPosition(Slot.EnderChest);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
            Mouse.SetCursorPosition(Slot.ech_2);
            await Task.Delay(craftDelay);
            Mouse.ClickL();
            await Task.Delay(craftDelay);
            Mouse.SetCursorPosition(Slot.ech_ech2);
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
}

HotPotatoBook.execute();