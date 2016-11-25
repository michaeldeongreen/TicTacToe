using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Tic.Tac.Toe.App.Services;
using Tic.Tac.Toe.App.Models.Enumerations;

namespace Tic.Tac.Toe.App.Unit.Tests
{
    [TestFixture]
    public class GameResultServiceTests
    {
        [Test]
        public void game_result_service_can_determine_no_winner_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 0] = "X";
            board[1, 0] = "O";
            board[2, 0] = "X";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.Type.Should().Be(GameResultType.NoWinner);
        }

        [Test]
        public void game_result_service_can_set_vertical_is_winner_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 0] = "X";
            board[1, 0] = "X";
            board[2, 0] = "X";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.Type.Should().Be(GameResultType.Winner);
        }

        [Test]
        public void game_result_service_can_set_a_vertical_winner_name_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 1] = "O";
            board[1, 1] = "O";
            board[2, 1] = "O";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.WinnerName.Should().Be("O");
        }

        [Test]
        public void game_result_service_can_set_vertical_winner_coordinates_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 2] = "O";
            board[1, 2] = "O";
            board[2, 2] = "O";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.WinningCoordinates.Should().Be("[0,2] [1,2] [2,2]");
        }

        [Test]
        public void game_result_service_can_set_horizontal_is_winner_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 0] = "X";
            board[0, 1] = "X";
            board[0, 2] = "X";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.Type.Should().Be(GameResultType.Winner);
        }

        [Test]
        public void game_result_service_can_set_a_horizontal_winner_name_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[1, 0] = "X";
            board[1, 1] = "X";
            board[1, 2] = "X";

            board[0, 1] = "O";
            board[2, 2] = "X";
            board[2, 1] = "O";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.WinnerName.Should().Be("X");
        }

        [Test]
        public void game_result_service_can_set_horizontal_winner_coordinates_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[2, 0] = "O";
            board[2, 1] = "O";
            board[2, 2] = "O";

            board[0, 0] = "X";
            board[1, 2] = "X";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.WinningCoordinates.Should().Be("[2,0] [2,1] [2,2]");
        }

        [Test]
        public void game_result_service_can_set_first_diagonal_is_winner_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 0] = "X";
            board[1, 1] = "X";
            board[2, 2] = "X";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.Type.Should().Be(GameResultType.Winner);
        }

        [Test]
        public void game_result_service_can_set_a_first_diagonal_winner_name_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 0] = "X";
            board[1, 1] = "X";
            board[2, 2] = "X";

            board[0, 1] = "O";
            board[2, 1] = "O";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.WinnerName.Should().Be("X");
        }

        [Test]
        public void game_result_service_can_set_first_diagnonal_winner_coordinates_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 0] = "O";
            board[1, 1] = "O";
            board[2, 2] = "O";

            board[2, 1] = "X";
            board[1, 2] = "X";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.WinningCoordinates.Should().Be("[0,0] [1,1] [2,2]");
        }

        [Test]
        public void game_result_service_can_set_second_diagonal_is_winner_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 2] = "O";
            board[1, 1] = "O";
            board[2, 0] = "O";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.Type.Should().Be(GameResultType.Winner);
        }

        [Test]
        public void game_result_service_can_set_a_second_diagonal_winner_name_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 2] = "X";
            board[1, 1] = "X";
            board[2, 0] = "X";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.WinnerName.Should().Be("X");
        }

        [Test]
        public void game_result_service_can_set_second_diagnonal_winner_coordinates_test()
        {
            //given
            string[,] board = new string[3, 3];
            board[0, 2] = "O";
            board[1, 1] = "O";
            board[2, 0] = "O";

            board[2, 1] = "X";
            board[1, 2] = "X";
            //when
            GameResultService service = new GameResultService(board);
            var results = service.GameResults();
            //then
            results.WinningCoordinates.Should().Be("[0,2] [1,1] [2,0]");
        }
    }
}
