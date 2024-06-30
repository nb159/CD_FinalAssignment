namespace libs;

public class NPC : GameObject {
    public NPC () : base() {
        this.Type = GameObjectType.NPC;
        this.CharRepresentation = '☺';
        this.Color = ConsoleColor.Yellow;
    
        Console.WriteLine(GameEngine.Instance.nodeText);
        //TODO Import and add those from JSON
        // DialogNode node1 = new DialogNode("hey, do you need any help?");
        // DialogNode node2 = new DialogNode("Sure, what information do you need?");
        // DialogNode node3 = new DialogNode("Sorry, I can't help with that.");
        // DialogNode node4 = new DialogNode("Here is the information you requested.");
        // DialogNode node5 = new DialogNode("Goodbye!");

        // // Adding responses to nodes
        // node1.AddResponse("I need some information.", node2);
        // node1.AddResponse("Nothing, thanks.", node5);

        // node2.AddResponse("Tell me more.", node4);
        // node2.AddResponse("Nevermind.", node3);

        // node3.AddResponse("Okay, goodbye.", node5);
        // node4.AddResponse("Thanks!", node5);

        // dialogNodes.Add(node1);
        // dialogNodes.Add(node2);
        // dialogNodes.Add(node3);
        // dialogNodes.Add(node4);
        // dialogNodes.Add(node5);

        // dialog.Add(new Dialog(node1));



        Console.WriteLine(GameEngine.Instance.nodeText);
        //TODO Import and add those from JSON
        DialogNode node_b1 = new DialogNode(GameEngine.Instance.nodeText[0]);
        DialogNode node_b2 = new DialogNode(GameEngine.Instance.nodeText[1]);
        DialogNode node_b3 = new DialogNode(GameEngine.Instance.nodeText[2]);
        DialogNode node_b4 = new DialogNode(GameEngine.Instance.nodeText[3]);
        DialogNode node_b5 = new DialogNode(GameEngine.Instance.nodeText[4]);

        // Adding responses to nodes
        node_b1.AddResponse(GameEngine.Instance.nodeResponses[0], node_b2);
        node_b1.AddResponse(GameEngine.Instance.nodeResponses[1], node_b5);

        node_b2.AddResponse(GameEngine.Instance.nodeResponses[2], node_b4);
        node_b2.AddResponse(GameEngine.Instance.nodeResponses[3], node_b3);

        node_b3.AddResponse(GameEngine.Instance.nodeResponses[4], node_b5);
        node_b4.AddResponse(GameEngine.Instance.nodeResponses[5], node_b5);

        dialogNodes.Add(node_b1);
        dialogNodes.Add(node_b2);
        dialogNodes.Add(node_b3);
        dialogNodes.Add(node_b4);
        dialogNodes.Add(node_b5);

        // dialog.Add(new Dialog(node_b1));
        dialog = new Dialog(node_b1);

    }
}   
