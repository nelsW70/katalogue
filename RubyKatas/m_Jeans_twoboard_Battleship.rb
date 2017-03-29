def draw_this(board)
  board.each do |row|
    row.each do |cell|
      print cell
    end
    puts
  end
  puts
end
# board = [
#           [0,0,0,0,0],
#           [0,0,0,0,0],
#           [0,0,0,0,0],
#           [0,0,0,0,0],
#           [0,0,0,0,0]
#         ]
# board[0] #=> [0,0,0,0,0] <-- this is 'row' first
# board[1] #=> [0,0,0,0,0] <-- next time the loop runs, this is 'row'
# board[0][0] #=> 0 <-- this is 'cell' first
# board[0][1] #=> 0 <-- this is 'cell' next time the loop runs.

secret_board = Array.new(5) {
  Array.new(5, false)
}
display_board = Array.new(5) {
  Array.new(5, '-')
}

# place a ship at 0,1 and 0,2
secret_board[0][1] = true
secret_board[0][2] = true

draw_this(display_board)

keep_looping = true

while keep_looping do
  # get a guess from the user
  puts "can you guess where my ships are?!?! enter two numbers, one for row and one for column"
  row = gets.to_i
  column = gets.to_i

  # see if the guess hit or not
  if secret_board[row][column] # == true
    puts "YOU HIT MY SHIP"
    display_board[row][column] = 'H'
    secret_board[row][column] = false
  else # this happens if secret_board[row][column] == false
    puts "Too bad, so sad, you missed"
    display_board[row][column] = 'm'
  end

  draw_this(display_board)
  # draw_this(secret_board)

  if secret_board.flatten.any?
    puts "there are still ships left to guess, keep going!"
  else
    puts "you got all my ships, good job!"
    keep_looping = false
  end
end
