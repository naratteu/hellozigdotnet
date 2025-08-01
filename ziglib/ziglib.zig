const std = @import("std");

export fn helloZig() void {
    std.debug.print("Hello Zig!\n", .{});
}
