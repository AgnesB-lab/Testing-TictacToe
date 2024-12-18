def test_x_wins():
    board = "xxx--o-o-"
    result = evaluate(board)
    assert result == "x"

def test_o_wins():
    board = "--oooxxx-"
    result = evaluate(board)
    assert result == "o"

def test_draw():
    board = "xoxoxoxox"
    result = evaluate(board)
    assert result == "!"

def test_no_winner_yet():
    board = "xox-xox-o"
    result = evaluate(board)
    assert result == "-"
