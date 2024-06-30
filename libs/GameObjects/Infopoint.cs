namespace libs;

public class Infopoint : GameObject {
    public Infopoint () : base() {
        this.Type = GameObjectType.Infopoint;
        this.CharRepresentation = '◙';
        this.Color = ConsoleColor.Cyan;

         DialogNode node_b1 = new DialogNode(GameEngine.Instance.nodeText[0]);
        DialogNode node_b2 = new DialogNode(GameEngine.Instance.nodeText[1]);
        DialogNode node_b3 = new DialogNode(GameEngine.Instance.nodeText[2]);
        DialogNode node_b4 = new DialogNode(GameEngine.Instance.nodeText[3]);
        DialogNode node_b5 = new DialogNode(GameEngine.Instance.nodeText[4]);

        // Adding responses to nodes
        node_b1.AddResponse(GameEngine.Instance.nodeResponses[0], node_b2);
        node_b1.AddResponse(GameEngine.Instance.nodeResponses[1], node_b5);

        node_b2.AddResponse(GameEngine.Instance.nodeResponses[2], node_b3);
        node_b2.AddResponse(GameEngine.Instance.nodeResponses[3], node_b5);

        node_b3.AddResponse(GameEngine.Instance.nodeResponses[4], node_b4);
        node_b3.AddResponse(GameEngine.Instance.nodeResponses[5], node_b5);

        dialogNodes.Add(node_b1);
        dialogNodes.Add(node_b2);
        dialogNodes.Add(node_b3);
        dialogNodes.Add(node_b4);
        dialogNodes.Add(node_b5);

        // dialog.Add(new Dialog(node_b1));
        dialog = new Dialog(node_b1);
    }
}