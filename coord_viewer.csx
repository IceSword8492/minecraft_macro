#load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\coord.csx"
#load "D:\Dドキュメント\programming\cs\minecraft_macro_key2key\mouse.csx"

while (true) {
    Console.WriteLine(
        "[" +
        Mouse.GetCursorPosition().x + ", " +
        Mouse.GetCursorPosition().y + "]"
    );
    await Task.Delay(100);
}