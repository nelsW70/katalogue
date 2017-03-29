# Create grid dimensions
size = 10

#create grid
grid = Array.new(size) {|row| Array.new(size, 0)}

hits = 0
final_score = 2

#create test ships
grid[5][4] = 1 #ship1
grid[7][2] = 1 #ship2

while true

#display grid
  for i in (0...size)
    for j in (0...size)
      print " ~~" unless grid[i][j] == 9 || grid[i][j] == 8
      print " X "if grid[i][j] == 9
      print " O "if grid[i][j] == 8
    end
    puts
  end

  break if final_score == hits

  #get guess from user
  puts "Enter a number between 1-9 for an x coordinate"
  x_coordinate = gets.chomp.to_i
  puts "Enter a number between 1-9 for a y coordinate"
  y_coordinate = gets.chomp.to_i

  #if hit/ miss
      if grid[x_coordinate][y_coordinate] == 1
        puts "\n HIT! \n \n";
        grid[x_coordinate][y_coordinate] = 9
        hits += 1  # hits = hits+1
      else
        puts "\n Miss! \n \n ";
        grid[x_coordinate][y_coordinate] = 8
      end
end

puts "YOU WIN!" ;
