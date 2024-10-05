<?xml version="1.0" encoding="utf-8" standalone="yes" ?>
<!--Torque Constructor Scene document http://www.garagegames.com-->
<ConstructorScene version="4" creator="Torque Constructor" date="2024/10/04 16:02:06">
    <Sunlight azimuth="180" elevation="35" color="255 255 255" ambient="64 64 64" />
    <LightingOptions lightingSystem="" ineditor_defaultLightmapSize="256" ineditor_maxLightmapSize="256" ineditor_lightingPerformanceHint="0" ineditor_shadowPerformanceHint="1" ineditor_TAPCompatibility="0" ineditor_useSunlight="0" export_defaultLightmapSize="256" export_maxLightmapSize="256" export_lightingPerformanceHint="0" export_shadowPerformanceHint="1" export_TAPCompatibility="0" export_useSunlight="0" />
    <GameTypes>
        <GameType name="Constructor" />
        <GameType name="Torque" />
    </GameTypes>
    <DetailLevels current="0">
        <DetailLevel minPixelSize="0" actionCenter="0 0 0">
            <InteriorMap brushScale="32" lightScale="32" ambientColor="0 0 0" ambientColorEmerg="0 0 0">
                <Entities nextEntityID="116">
                    <Entity id="0" classname="worldspawn" gametype="Torque" isPointEntity="0">
                        <Properties detail_number="0" min_pixels="250" geometry_scale="32.0" light_geometry_scale="32.0" light_smoothing_scale="4.0" light_mesh_scale="1.0" ambient_color="0 0 0" emergency_ambient_color="0 0 0" mapversion="220" _tb_def="builtin:marbleblast.fgd" />
                    </Entity>
                </Entities>
                <Brushes nextBrushID="352">
                    <Brush id="0" owner="0" type="0" pos="-8 10 -36" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 10 0 0 1 -36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -26 -4" />
                            <Vertex pos="-4 -26 4" />
                            <Vertex pos="-4 26 -4" />
                            <Vertex pos="-4 26 4" />
                            <Vertex pos="4 -26 -4" />
                            <Vertex pos="4 -26 4" />
                            <Vertex pos="4 26 -4" />
                            <Vertex pos="4 26 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -26" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -1024 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_tile11_B" texgens="1 0 0 -2048 0 -1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -26" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1024 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1280 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="1" owner="0" type="0" pos="52 -12 -6" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 -12 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -34" />
                            <Vertex pos="-4 -4 34" />
                            <Vertex pos="-4 4 -34" />
                            <Vertex pos="-4 4 34" />
                            <Vertex pos="4 -4 -34" />
                            <Vertex pos="4 -4 34" />
                            <Vertex pos="4 4 -34" />
                            <Vertex pos="4 4 34" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_tile08_B" texgens="0 -1 0 3072 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -34" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -34" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="2" owner="0" type="0" pos="-8 48 -6" rot="1 0 0 0" scale="" transform="1 0 0 -8 0 1 0 48 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -34" />
                            <Vertex pos="-4 -4 34" />
                            <Vertex pos="-4 4 -34" />
                            <Vertex pos="-4 4 34" />
                            <Vertex pos="4 -4 -34" />
                            <Vertex pos="4 -4 34" />
                            <Vertex pos="4 4 -34" />
                            <Vertex pos="4 4 34" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_tile01_B" texgens="1 0 0 -2048 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -34" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1024 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -34" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -1024 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1024 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="3" owner="0" type="0" pos="-18 48 34" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 48 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -4 -6" />
                            <Vertex pos="-6 -4 6" />
                            <Vertex pos="-6 4 -6" />
                            <Vertex pos="-6 4 6" />
                            <Vertex pos="6 -4 -6" />
                            <Vertex pos="6 -4 6" />
                            <Vertex pos="6 4 -6" />
                            <Vertex pos="6 4 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -4608 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="4" owner="0" type="0" pos="52 -22 34" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 -22 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -6 -6" />
                            <Vertex pos="-4 -6 6" />
                            <Vertex pos="-4 6 -6" />
                            <Vertex pos="-4 6 6" />
                            <Vertex pos="4 -6 -6" />
                            <Vertex pos="4 -6 6" />
                            <Vertex pos="4 6 -6" />
                            <Vertex pos="4 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 5632 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="5" owner="0" type="0" pos="48.25 -16 40.25" rot="1 0 0 0" scale="" transform="1 0 0 48.25 0 1 0 -16 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -12 -0.25" />
                            <Vertex pos="-0.25 -12 0.25" />
                            <Vertex pos="-0.25 12 -0.25" />
                            <Vertex pos="-0.25 12 0.25" />
                            <Vertex pos="0.25 -12 -0.25" />
                            <Vertex pos="0.25 -12 0.25" />
                            <Vertex pos="0.25 12 -0.25" />
                            <Vertex pos="0.25 12 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -12" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -12" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="6" owner="0" type="0" pos="45 -9.75 40.25" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 -9.75 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="7" owner="0" type="0" pos="-12 44.25 40.25" rot="1 0 0 0" scale="" transform="1 0 0 -12 0 1 0 44.25 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12 -0.25 -0.25" />
                            <Vertex pos="-12 -0.25 0.25" />
                            <Vertex pos="-12 0.25 -0.25" />
                            <Vertex pos="-12 0.25 0.25" />
                            <Vertex pos="12 -0.25 -0.25" />
                            <Vertex pos="12 -0.25 0.25" />
                            <Vertex pos="12 0.25 -0.25" />
                            <Vertex pos="12 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -12" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 3072 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 3072 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -12" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="8" owner="0" type="0" pos="-18 -22 -36" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -22 0 0 1 -36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -4" />
                            <Vertex pos="-6 -6 4" />
                            <Vertex pos="-6 6 -4" />
                            <Vertex pos="-6 6 4" />
                            <Vertex pos="6 -6 -4" />
                            <Vertex pos="6 -6 4" />
                            <Vertex pos="6 6 -4" />
                            <Vertex pos="6 6 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 2816 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_friction_sand" texgens="0 1 0 -5632 1 0 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2816 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="9" owner="0" type="0" pos="-24.25 44.25 28.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 44.25 0 0 1 28.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -12.25" />
                            <Vertex pos="-0.25 -0.25 12.25" />
                            <Vertex pos="-0.25 0.25 -12.25" />
                            <Vertex pos="-0.25 0.25 12.25" />
                            <Vertex pos="0.25 -0.25 -12.25" />
                            <Vertex pos="0.25 -0.25 12.25" />
                            <Vertex pos="0.25 0.25 -12.25" />
                            <Vertex pos="0.25 0.25 12.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 3136 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -12.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -12.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 3136 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="10" owner="0" type="0" pos="-6 -22 -36" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 -22 0 0 1 -36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -4" />
                            <Vertex pos="-6 -6 4" />
                            <Vertex pos="-6 6 -4" />
                            <Vertex pos="-6 6 4" />
                            <Vertex pos="6 -6 -4" />
                            <Vertex pos="6 -6 4" />
                            <Vertex pos="6 6 -4" />
                            <Vertex pos="6 6 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2816 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -768 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -1536 0 1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="11" owner="0" type="0" pos="48.25 -28.25 28.25" rot="1 0 0 0" scale="" transform="1 0 0 48.25 0 1 0 -28.25 0 0 1 28.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -12.25" />
                            <Vertex pos="-0.25 -0.25 12.25" />
                            <Vertex pos="-0.25 0.25 -12.25" />
                            <Vertex pos="-0.25 0.25 12.25" />
                            <Vertex pos="0.25 -0.25 -12.25" />
                            <Vertex pos="0.25 -0.25 12.25" />
                            <Vertex pos="0.25 0.25 -12.25" />
                            <Vertex pos="0.25 0.25 12.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 3136 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -12.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -12.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 3136 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 3136 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="12" owner="0" type="0" pos="-12.25 -28.25 -32.25" rot="1 0 0 0" scale="" transform="1 0 0 -12.25 0 1 0 -28.25 0 0 1 -32.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-12.25 -0.25 -0.25" />
                            <Vertex pos="-12.25 -0.25 0.25" />
                            <Vertex pos="-12.25 0.25 -0.25" />
                            <Vertex pos="-12.25 0.25 0.25" />
                            <Vertex pos="12.25 -0.25 -0.25" />
                            <Vertex pos="12.25 -0.25 0.25" />
                            <Vertex pos="12.25 0.25 -0.25" />
                            <Vertex pos="12.25 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -12.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 3136 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 3136 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 3136 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 3136 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -12.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="13" owner="0" type="0" pos="-24.25 -16 -32.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 -16 0 0 1 -32.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -12 -0.25" />
                            <Vertex pos="-0.25 -12 0.25" />
                            <Vertex pos="-0.25 12 -0.25" />
                            <Vertex pos="-0.25 12 0.25" />
                            <Vertex pos="0.25 -12 -0.25" />
                            <Vertex pos="0.25 -12 0.25" />
                            <Vertex pos="0.25 12 -0.25" />
                            <Vertex pos="0.25 12 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 3072 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -12" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 3072 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 3072 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -12" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 3072 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="14" owner="0" type="0" pos="-18 -10 -36" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 -10 0 0 1 -36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -4" />
                            <Vertex pos="-6 -6 4" />
                            <Vertex pos="-6 6 -4" />
                            <Vertex pos="-6 6 4" />
                            <Vertex pos="6 -6 -4" />
                            <Vertex pos="6 -6 4" />
                            <Vertex pos="6 6 -4" />
                            <Vertex pos="6 6 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 1280 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_friction_sand" texgens="0 1 0 -2560 1 0 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="15" owner="0" type="0" pos="-18 0 -35" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 0 0 0 1 -35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -4 3" />
                            <Vertex pos="-6 -4 -5" />
                            <Vertex pos="-6 4 5" />
                            <Vertex pos="-6 4 -5" />
                            <Vertex pos="6 -4 3" />
                            <Vertex pos="6 -4 -5" />
                            <Vertex pos="6 4 5" />
                            <Vertex pos="6 4 -5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 0 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.242536 0.970142 -3.88057" album="Blasted" material="bm_friction_sand" texgens="0 1 0 0 1 0 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="16" owner="0" type="0" pos="-18 10 -35" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 10 0 0 1 -35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -5" />
                            <Vertex pos="-6 -6 5" />
                            <Vertex pos="-6 6 -5" />
                            <Vertex pos="-6 6 5" />
                            <Vertex pos="6 -6 -5" />
                            <Vertex pos="6 -6 5" />
                            <Vertex pos="6 6 -5" />
                            <Vertex pos="6 6 5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1280 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -5" album="Blasted" material="bm_friction_sand" texgens="0 1 0 2560 1 0 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1280 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="17" owner="0" type="0" pos="-18 20 -34" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 20 0 0 1 -34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -4 4" />
                            <Vertex pos="-6 -4 -6" />
                            <Vertex pos="-6 4 6" />
                            <Vertex pos="-6 4 -6" />
                            <Vertex pos="6 -4 4" />
                            <Vertex pos="6 -4 -6" />
                            <Vertex pos="6 4 6" />
                            <Vertex pos="6 4 -6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -2560 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.242536 0.970142 -4.85071" album="Blasted" material="bm_friction_sand" texgens="0 1 0 5120 1 0 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2560 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="18" owner="0" type="0" pos="-18 30 -34" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 30 0 0 1 -34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -6" />
                            <Vertex pos="-6 -6 6" />
                            <Vertex pos="-6 6 -6" />
                            <Vertex pos="-6 6 6" />
                            <Vertex pos="6 -6 -6" />
                            <Vertex pos="6 -6 6" />
                            <Vertex pos="6 6 -6" />
                            <Vertex pos="6 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -3840 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_friction_sand" texgens="0 1 0 7680 1 0 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 3840 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="19" owner="0" type="0" pos="-18 48 22" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 48 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -4 -6" />
                            <Vertex pos="-6 -4 6" />
                            <Vertex pos="-6 4 -6" />
                            <Vertex pos="-6 4 6" />
                            <Vertex pos="6 -4 -6" />
                            <Vertex pos="6 -4 6" />
                            <Vertex pos="6 4 -6" />
                            <Vertex pos="6 4 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0 0 -1 -2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -4608 0 0 -1 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0 0 -1 -2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="20" owner="0" type="0" pos="-18 47 12" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 47 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -5 -4" />
                            <Vertex pos="-6 -3 4" />
                            <Vertex pos="-6 5 -4" />
                            <Vertex pos="-6 5 4" />
                            <Vertex pos="6 -5 -4" />
                            <Vertex pos="6 -3 4" />
                            <Vertex pos="6 5 -4" />
                            <Vertex pos="6 5 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6016 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.970142 0.242536 -3.88057" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -4608 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6016 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="21" owner="0" type="0" pos="-18 47 2" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 47 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -5 -6" />
                            <Vertex pos="-6 -5 6" />
                            <Vertex pos="-6 5 -6" />
                            <Vertex pos="-6 5 6" />
                            <Vertex pos="6 -5 -6" />
                            <Vertex pos="6 -5 6" />
                            <Vertex pos="6 5 -6" />
                            <Vertex pos="6 5 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6016 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -5" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -4608 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6016 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="22" owner="0" type="0" pos="-18 46 -8" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 46 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -4" />
                            <Vertex pos="-6 -4 4" />
                            <Vertex pos="-6 6 -4" />
                            <Vertex pos="-6 6 4" />
                            <Vertex pos="6 -6 -4" />
                            <Vertex pos="6 -4 4" />
                            <Vertex pos="6 6 -4" />
                            <Vertex pos="6 6 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -5888 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.970142 0.242536 -4.85071" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -4608 0 0 -1 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 5888 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="23" owner="0" type="0" pos="-18 46 -26" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 46 0 0 1 -26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -14" />
                            <Vertex pos="-6 -6 14" />
                            <Vertex pos="-6 6 -14" />
                            <Vertex pos="-6 6 14" />
                            <Vertex pos="6 -6 -14" />
                            <Vertex pos="6 -6 14" />
                            <Vertex pos="6 6 -14" />
                            <Vertex pos="6 6 14" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -5888 0 0 -1 3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -4608 0 0 -1 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -14" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -14" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 -1 0 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 5888 0 0 -1 3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="24" owner="0" type="0" pos="-18 38 -32" rot="1 0 0 0" scale="" transform="1 0 0 -18 0 1 0 38 0 0 1 -32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -2 4" />
                            <Vertex pos="-6 -2 -8" />
                            <Vertex pos="-6 2 8" />
                            <Vertex pos="-6 2 -8" />
                            <Vertex pos="6 -2 4" />
                            <Vertex pos="6 -2 -8" />
                            <Vertex pos="6 2 8" />
                            <Vertex pos="6 2 -8" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -4864 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -2304 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 0.707107 -4.24264" album="Blasted" material="bm_friction_sand" texgens="0 1 0 9728 1 0 0 -4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 -1 0 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2304 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 4864 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="25" owner="0" type="0" pos="18 40 -32" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 40 0 0 1 -32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30 -4 0" />
                            <Vertex pos="-30 -4 -8" />
                            <Vertex pos="-30 4 8" />
                            <Vertex pos="-30 4 -8" />
                            <Vertex pos="30 -4 1.90735e-006" />
                            <Vertex pos="30 -4 -8" />
                            <Vertex pos="30 4 8" />
                            <Vertex pos="30 4 -8" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -30" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -5120 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-2.24783e-008 -0.707107 0.707107 -2.82843" album="Blasted" material="bm_friction_sand" texgens="0 1 0 10240 1 0 0 4608 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 -5120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -30" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 5120 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="26" owner="0" type="0" pos="-6 48 34" rot="1 0 0 0" scale="" transform="1 0 0 -6 0 1 0 48 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -4 -6" />
                            <Vertex pos="-6 -4 6" />
                            <Vertex pos="-6 4 -6" />
                            <Vertex pos="-6 4 6" />
                            <Vertex pos="6 -4 -6" />
                            <Vertex pos="6 -4 6" />
                            <Vertex pos="6 4 -6" />
                            <Vertex pos="6 4 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_friction_sand" texgens="1 0 0 -1536 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 768 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -768 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 768 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="27" owner="0" type="0" pos="4 47 34" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 47 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -3 -6" />
                            <Vertex pos="-4 -3 6" />
                            <Vertex pos="-4 5 -6" />
                            <Vertex pos="-4 5 6" />
                            <Vertex pos="4 -5 -6" />
                            <Vertex pos="4 -5 6" />
                            <Vertex pos="4 5 -6" />
                            <Vertex pos="4 5 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6016 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.242536 -0.970142 0 -3.88057" album="Blasted" material="bm_friction_sand" texgens="1 0 0 1024 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 512 0 -1 0 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6016 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="28" owner="0" type="0" pos="14 47 34" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 47 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -5 -6" />
                            <Vertex pos="-6 -5 6" />
                            <Vertex pos="-6 5 -6" />
                            <Vertex pos="-6 5 6" />
                            <Vertex pos="6 -5 -6" />
                            <Vertex pos="6 -5 6" />
                            <Vertex pos="6 5 -6" />
                            <Vertex pos="6 5 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6016 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -5" album="Blasted" material="bm_friction_sand" texgens="1 0 0 3584 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1792 0 -1 0 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 1792 0 -1 0 -6016 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1792 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6016 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="29" owner="0" type="0" pos="24 46 34" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 46 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -6" />
                            <Vertex pos="-4 -4 6" />
                            <Vertex pos="-4 6 -6" />
                            <Vertex pos="-4 6 6" />
                            <Vertex pos="4 -6 -6" />
                            <Vertex pos="4 -6 6" />
                            <Vertex pos="4 6 -6" />
                            <Vertex pos="4 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -5888 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.242536 -0.970142 0 -4.85071" album="Blasted" material="bm_friction_sand" texgens="1 0 0 6144 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3072 0 -1 0 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 3072 0 -1 0 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3072 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 5888 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="30" owner="0" type="0" pos="42 46 34" rot="1 0 0 0" scale="" transform="1 0 0 42 0 1 0 46 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14 -6 -6" />
                            <Vertex pos="-14 -6 6" />
                            <Vertex pos="-14 6 -6" />
                            <Vertex pos="-14 6 6" />
                            <Vertex pos="14 -6 -6" />
                            <Vertex pos="14 -6 6" />
                            <Vertex pos="14 6 -6" />
                            <Vertex pos="14 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -14" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -5888 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_friction_sand" texgens="1 0 0 10752 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -5376 0 -1 0 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 5376 0 -1 0 -5888 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -5376 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -14" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 5888 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="31" owner="0" type="0" pos="4 -22 -35" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -22 0 0 1 -35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -6 3" />
                            <Vertex pos="-4 6 3" />
                            <Vertex pos="-4 -6 -5" />
                            <Vertex pos="-4 6 -5" />
                            <Vertex pos="4 -6 5" />
                            <Vertex pos="4 6 5" />
                            <Vertex pos="4 -6 -5" />
                            <Vertex pos="4 6 -5" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -4" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2816 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.242536 0 0.970142 -3.88057" album="Blasted" material="bm_friction_sand" texgens="1 0 0 1024 0 1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="4" plane="0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -512 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="32" owner="0" type="0" pos="14 -22 -35" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -22 0 0 1 -35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -5" />
                            <Vertex pos="-6 -6 5" />
                            <Vertex pos="-6 6 -5" />
                            <Vertex pos="-6 6 5" />
                            <Vertex pos="6 -6 -5" />
                            <Vertex pos="6 -6 5" />
                            <Vertex pos="6 6 -5" />
                            <Vertex pos="6 6 5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2816 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 1792 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1792 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -5" album="Blasted" material="bm_friction_sand" texgens="1 0 0 3584 0 1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1792 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 4480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="33" owner="0" type="0" pos="24 -22 -34" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -22 0 0 1 -34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -6 4" />
                            <Vertex pos="-4 6 4" />
                            <Vertex pos="-4 -6 -6" />
                            <Vertex pos="-4 6 -6" />
                            <Vertex pos="4 -6 6" />
                            <Vertex pos="4 6 6" />
                            <Vertex pos="4 -6 -6" />
                            <Vertex pos="4 6 -6" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -4" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2816 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.242536 0 0.970142 -4.85071" album="Blasted" material="bm_friction_sand" texgens="1 0 0 6144 0 1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 3072 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3072 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="4" plane="0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3072 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="34" owner="0" type="0" pos="34 -22 -34" rot="1 0 0 0" scale="" transform="1 0 0 34 0 1 0 -22 0 0 1 -34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -6" />
                            <Vertex pos="-6 -6 6" />
                            <Vertex pos="-6 6 -6" />
                            <Vertex pos="-6 6 6" />
                            <Vertex pos="6 -6 -6" />
                            <Vertex pos="6 -6 6" />
                            <Vertex pos="6 6 -6" />
                            <Vertex pos="6 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2816 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 4352 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -4352 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_friction_sand" texgens="1 0 0 8704 0 1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -4352 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="35" owner="0" type="0" pos="52 -22 22" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 -22 0 0 1 22 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -6 -6" />
                            <Vertex pos="-4 -6 6" />
                            <Vertex pos="-4 6 -6" />
                            <Vertex pos="-4 6 6" />
                            <Vertex pos="4 -6 -6" />
                            <Vertex pos="4 -6 6" />
                            <Vertex pos="4 6 -6" />
                            <Vertex pos="4 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 5632 0 0 -1 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0 -1 -2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0 -1 -2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 -2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="36" owner="0" type="0" pos="51 -22 12" rot="1 0 0 0" scale="" transform="1 0 0 51 0 1 0 -22 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5 -6 -4" />
                            <Vertex pos="-3 -6 4" />
                            <Vertex pos="-5 6 -4" />
                            <Vertex pos="-3 6 4" />
                            <Vertex pos="5 -6 -4" />
                            <Vertex pos="5 -6 4" />
                            <Vertex pos="5 6 -4" />
                            <Vertex pos="5 6 4" />
                        </Vertices>
                        <Face id="0" plane="-0.970142 0 0.242536 -3.88057" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 5632 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6528 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6528 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6528 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6528 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="37" owner="0" type="0" pos="51 -22 2" rot="1 0 0 0" scale="" transform="1 0 0 51 0 1 0 -22 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5 -6 -6" />
                            <Vertex pos="-5 -6 6" />
                            <Vertex pos="-5 6 -6" />
                            <Vertex pos="-5 6 6" />
                            <Vertex pos="5 -6 -6" />
                            <Vertex pos="5 -6 6" />
                            <Vertex pos="5 6 -6" />
                            <Vertex pos="5 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -5" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 5632 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6528 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6528 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6528 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6528 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 -256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="38" owner="0" type="0" pos="50 -22 -8" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 -22 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -4" />
                            <Vertex pos="-4 -6 4" />
                            <Vertex pos="-6 6 -4" />
                            <Vertex pos="-4 6 4" />
                            <Vertex pos="6 -6 -4" />
                            <Vertex pos="6 -6 4" />
                            <Vertex pos="6 6 -4" />
                            <Vertex pos="6 6 4" />
                        </Vertices>
                        <Face id="0" plane="-0.970142 0 0.242536 -4.85071" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 5632 0 0 -1 2048 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6400 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6400 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6400 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6400 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 1024 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="39" owner="0" type="0" pos="50 -22 -26" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 -22 0 0 1 -26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -14" />
                            <Vertex pos="-6 -6 14" />
                            <Vertex pos="-6 6 -14" />
                            <Vertex pos="-6 6 14" />
                            <Vertex pos="6 -6 -14" />
                            <Vertex pos="6 -6 14" />
                            <Vertex pos="6 6 -14" />
                            <Vertex pos="6 6 14" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 5632 0 0 -1 6656 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6400 0 0 -1 3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -14" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6400 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -14" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6400 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6400 0 0 -1 3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 3328 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="40" owner="0" type="0" pos="18 -12 -36" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 -12 0 0 1 -36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-22 -4 -4" />
                            <Vertex pos="-22 -4 4" />
                            <Vertex pos="-22 4 -4" />
                            <Vertex pos="-22 4 4" />
                            <Vertex pos="22 -4 -4" />
                            <Vertex pos="22 -4 4" />
                            <Vertex pos="22 4 -4" />
                            <Vertex pos="22 4 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -22" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 1536 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_tile11_B" texgens="1 0 0 4608 0 -1 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -22" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1536 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="41" owner="0" type="0" pos="42 -22 -32" rot="1 0 0 0" scale="" transform="1 0 0 42 0 1 0 -22 0 0 1 -32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -6 3.99999" />
                            <Vertex pos="-2 6 3.99999" />
                            <Vertex pos="-2 -6 -7.99999" />
                            <Vertex pos="-2 6 -7.99999" />
                            <Vertex pos="2 -6 7.99999" />
                            <Vertex pos="2 6 7.99999" />
                            <Vertex pos="2 -6 -7.99999" />
                            <Vertex pos="2 6 -7.99999" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -2" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2816 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -4.24263" album="Blasted" material="bm_friction_sand" texgens="1 0 0 10752 0 1 0 -5632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 5376 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -7.99999" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -5376 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="4" plane="0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -5376 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -2" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="42" owner="0" type="0" pos="52 -10 34" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 -10 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -6 -6" />
                            <Vertex pos="-4 -6 6" />
                            <Vertex pos="-4 6 -6" />
                            <Vertex pos="-4 6 6" />
                            <Vertex pos="4 -6 -6" />
                            <Vertex pos="4 -6 6" />
                            <Vertex pos="4 6 -6" />
                            <Vertex pos="4 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 2560 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -1 0 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1280 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="43" owner="0" type="0" pos="51 0 34" rot="1 0 0 0" scale="" transform="1 0 0 51 0 1 0 0 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -4 -6" />
                            <Vertex pos="-3 -4 6" />
                            <Vertex pos="-5 4 -6" />
                            <Vertex pos="-5 4 6" />
                            <Vertex pos="5 -4 -6" />
                            <Vertex pos="5 -4 6" />
                            <Vertex pos="5 4 -6" />
                            <Vertex pos="5 4 6" />
                        </Vertices>
                        <Face id="0" plane="-0.970142 -0.242536 -0 -3.88057" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 0 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6528 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6528 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6528 0 -1 0 0 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6528 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 0 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="44" owner="0" type="0" pos="51 10 34" rot="1 0 0 0" scale="" transform="1 0 0 51 0 1 0 10 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-5 -6 -6" />
                            <Vertex pos="-5 -6 6" />
                            <Vertex pos="-5 6 -6" />
                            <Vertex pos="-5 6 6" />
                            <Vertex pos="5 -6 -6" />
                            <Vertex pos="5 -6 6" />
                            <Vertex pos="5 6 -6" />
                            <Vertex pos="5 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -5" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 -2560 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6528 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6528 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6528 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6528 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -5" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1280 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="45" owner="0" type="0" pos="50 20 34" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 20 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 -6" />
                            <Vertex pos="-4 -4 6" />
                            <Vertex pos="-6 4 -6" />
                            <Vertex pos="-6 4 6" />
                            <Vertex pos="6 -4 -6" />
                            <Vertex pos="6 -4 6" />
                            <Vertex pos="6 4 -6" />
                            <Vertex pos="6 4 6" />
                        </Vertices>
                        <Face id="0" plane="-0.970142 -0.242536 -0 -4.85071" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 -5120 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6400 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6400 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6400 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6400 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2560 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="46" owner="0" type="0" pos="50 30 34" rot="1 0 0 0" scale="" transform="1 0 0 50 0 1 0 30 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -6 -6" />
                            <Vertex pos="-6 -6 6" />
                            <Vertex pos="-6 6 -6" />
                            <Vertex pos="-6 6 6" />
                            <Vertex pos="6 -6 -6" />
                            <Vertex pos="6 -6 6" />
                            <Vertex pos="6 6 -6" />
                            <Vertex pos="6 6 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 -7680 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6400 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6400 0 -1 0 -3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6400 0 -1 0 -3840 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6400 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 3840 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="47" owner="0" type="0" pos="44 14 -32" rot="1 0 0 0" scale="" transform="1 0 0 44 0 1 0 14 0 0 1 -32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -30 1.90735e-006" />
                            <Vertex pos="-4 30 1.90735e-006" />
                            <Vertex pos="-4 -30 -8" />
                            <Vertex pos="-4 30 -8" />
                            <Vertex pos="4 -30 8" />
                            <Vertex pos="4 30 8" />
                            <Vertex pos="4 -30 -8" />
                            <Vertex pos="4 30 -8" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -4" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1792 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707107 0 0.707107 -2.82843" album="Blasted" material="bm_friction_sand" texgens="1 0 0 11264 0 1 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -30" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 5632 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -5632 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="4" plane="0 1 0 -30" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -5632 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="48" owner="0" type="0" pos="48 38 34" rot="1 0 0 0" scale="" transform="1 0 0 48 0 1 0 38 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -2 -6" />
                            <Vertex pos="-4 -2 6" />
                            <Vertex pos="-8 2 -6" />
                            <Vertex pos="-8 2 6" />
                            <Vertex pos="8 -2 -6" />
                            <Vertex pos="8 -2 6" />
                            <Vertex pos="8 2 -6" />
                            <Vertex pos="8 2 6" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -4.24264" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 -9728 0 0 -1 -8704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6144 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6144 0 -1 0 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6144 0 -1 0 -4864 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -2" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6144 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -8" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 4864 0 0 -1 -4352 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="49" owner="0" type="0" pos="26 48 24" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 48 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30 -4 -4" />
                            <Vertex pos="-30 -4 4" />
                            <Vertex pos="-30 4 -4" />
                            <Vertex pos="-30 4 4" />
                            <Vertex pos="30 -4 -4" />
                            <Vertex pos="30 -4 4" />
                            <Vertex pos="30 4 -4" />
                            <Vertex pos="30 4 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -30" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_tile01_B" texgens="1 0 0 6656 0 0 -1 -6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 3328 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -30" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="50" owner="0" type="0" pos="48 40 -6" rot="1 0 0 0" scale="" transform="1 0 0 48 0 1 0 40 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0 -4 -34" />
                            <Vertex pos="0 -4 34" />
                            <Vertex pos="-8 4 -34" />
                            <Vertex pos="-8 4 34" />
                            <Vertex pos="8 -4 -34" />
                            <Vertex pos="8 -4 34" />
                            <Vertex pos="8 4 -34" />
                            <Vertex pos="8 4 34" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -2.82843" album="Blasted" material="bm_friction_sand" texgens="0 -1 0 -10240 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6144 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -34" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6144 0 -1 0 -5120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -34" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6144 0 -1 0 -5120 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6144 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -8" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 5120 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="51" owner="0" type="0" pos="52 14 24" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 14 0 0 1 24 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -22 -4" />
                            <Vertex pos="-4 -22 4" />
                            <Vertex pos="-4 22 -4" />
                            <Vertex pos="-4 22 4" />
                            <Vertex pos="4 -22 -4" />
                            <Vertex pos="4 -22 4" />
                            <Vertex pos="4 22 -4" />
                            <Vertex pos="4 22 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_tile08_B" texgens="0 -1 0 -3584 0 0 -1 -6144 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -22" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -22" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0 0 -1 -3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="52" owner="0" type="0" pos="0 14 -36" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 14 0 0 1 -36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 22 -4" />
                            <Vertex pos="-4 -22 -4" />
                            <Vertex pos="-4 22 4" />
                            <Vertex pos="-4 -22 4" />
                            <Vertex pos="4 14 -4" />
                            <Vertex pos="4 -14 -4" />
                            <Vertex pos="4 14 2" />
                            <Vertex pos="4 -14 2" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1792 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.242536 -0 0.970142 -2.91043" album="Blasted" material="bm_friction_ice" texgens="1 0 0 0 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="0.707107 0.707107 0 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="-0.707107 0.707107 0 1267.14 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0.707107 -0.707107 0 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0.707107 0.707107 0 1267.14 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="53" owner="0" type="0" pos="18 -4 -36" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 -4 0 0 1 -36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-22 -4 -4" />
                            <Vertex pos="-22 -4 4" />
                            <Vertex pos="-14 4 -4" />
                            <Vertex pos="-14 4 2" />
                            <Vertex pos="22 -4 -4" />
                            <Vertex pos="22 -4 4" />
                            <Vertex pos="14 4 -4" />
                            <Vertex pos="14 4 2" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 0.707107 0 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="-0.707107 -0.707107 0 -1267.14 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.242536 0.970142 -2.91043" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4608 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0.707107 -0 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="-0.707107 0.707107 0 -1991.21 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="54" owner="0" type="0" pos="36 14 -36" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 14 0 0 1 -36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 14 2" />
                            <Vertex pos="-4 14 -4" />
                            <Vertex pos="-4 -14 2" />
                            <Vertex pos="-4 -14 -4" />
                            <Vertex pos="4 22 4" />
                            <Vertex pos="4 22 -4" />
                            <Vertex pos="4 -22 4" />
                            <Vertex pos="4 -22 -4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1792 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="-0.707107 -0.707107 0 -4525.48 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-0.707107 -0.707107 0 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0.707107 -0.707107 0 1991.21 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="3" plane="-0.242536 0 0.970142 -2.91043" album="Blasted" material="bm_friction_ice" texgens="1 0 0 9216 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="4" plane="0 -0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -4608 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="55" owner="0" type="0" pos="18 32 -36" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 32 0 0 1 -36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14 -4 2" />
                            <Vertex pos="-14 -4 -4" />
                            <Vertex pos="-22 4 4" />
                            <Vertex pos="-22 4 -4" />
                            <Vertex pos="14 -4 2" />
                            <Vertex pos="14 -4 -4" />
                            <Vertex pos="22 4 4" />
                            <Vertex pos="22 4 -4" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0.707107 -0.707107 0 -1267.14 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.242536 0.970142 -2.91043" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4608 0 -1 0 -8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="0.707107 -0.707107 0 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0.707107 0.707107 0 4525.48 0 0 -1 4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="56" owner="0" type="0" pos="18 14 -37" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 14 0 0 1 -37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14 -14 -3" />
                            <Vertex pos="-14 -14 3" />
                            <Vertex pos="-14 14 -3" />
                            <Vertex pos="-14 14 3" />
                            <Vertex pos="14 -14 -3" />
                            <Vertex pos="14 -14 3" />
                            <Vertex pos="14 14 -3" />
                            <Vertex pos="14 14 3" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -14" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -1792 0 0 -1 4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -14" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 2304 0 0 -1 4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -3" album="Blasted" material="bm_tile11_B" texgens="1 0 0 4608 0 -1 0 -3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -14" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -14" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0 0 -1 4736 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="57" owner="0" type="0" pos="11 21 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 21 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2688 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1408 0 -1 0 -2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2816 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2688 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="58" owner="0" type="0" pos="13 19 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 19 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2432 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 -1 0 -2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3328 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1664 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2432 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="59" owner="0" type="0" pos="13 21 -33.5" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 21 0 0 1 -33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2688 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 -1 0 -2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3328 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1664 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2688 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="60" owner="0" type="0" pos="11 17 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 17 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2176 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1408 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2816 0 -1 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2176 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="61" owner="0" type="0" pos="19 17 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 17 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2176 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2432 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2432 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4864 0 -1 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2432 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2176 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="62" owner="0" type="0" pos="21 15 -33.5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 15 0 0 1 -33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -3 -0.5" />
                            <Vertex pos="-1 -3 0.5" />
                            <Vertex pos="-1 3 -0.5" />
                            <Vertex pos="-1 3 0.5" />
                            <Vertex pos="1 -3 -0.5" />
                            <Vertex pos="1 -3 0.5" />
                            <Vertex pos="1 3 -0.5" />
                            <Vertex pos="1 3 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1920 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2688 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5376 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -3" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2688 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1920 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="63" owner="0" type="0" pos="19 13 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 13 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1664 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2432 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2432 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4864 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2432 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1664 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="64" owner="0" type="0" pos="23 15 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 15 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1920 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2944 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2944 0 -1 0 -1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5888 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2944 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1920 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="65" owner="0" type="0" pos="21 11 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 11 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2688 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 -1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5376 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2688 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="66" owner="0" type="0" pos="9 7 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 7 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -896 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1152 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1152 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2304 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1152 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 896 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="67" owner="0" type="0" pos="11 5 -33.5" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 5 0 0 1 -33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -640 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1408 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1408 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2816 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1408 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 640 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="68" owner="0" type="0" pos="13 5 -32.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 5 0 0 1 -32.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.250004" />
                            <Vertex pos="-1 1 -0.250004" />
                            <Vertex pos="-1 -1 -0.75" />
                            <Vertex pos="-1 1 -0.75" />
                            <Vertex pos="1 -1 0.749998" />
                            <Vertex pos="1 1 0.749998" />
                            <Vertex pos="1 -1 0.249996" />
                            <Vertex pos="1 1 0.249996" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -640 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.447214 0 0.894427 -0.223604" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3328 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1664 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.447212 0 -0.894428 -0.223609" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 640 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="69" owner="0" type="0" pos="15 5 -32.75" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 5 0 0 1 -32.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 -1 0.75" />
                            <Vertex pos="-1 1 0.75" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="1 1 -0.75" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -640 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.447214 -0 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1920 0 1 0 640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1920 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1920 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0.447214 -0 0.894427 -0.223607" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3840 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 640 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="70" owner="0" type="0" pos="17 5 -33.5" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 5 0 0 1 -33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -640 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2176 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2176 0 -1 0 -640 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4352 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2176 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 640 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="71" owner="0" type="0" pos="29 23 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 23 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2944 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3712 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3712 0 -1 0 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 7424 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3712 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2944 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="72" owner="0" type="0" pos="27 25 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 25 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -3200 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3456 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3456 0 -1 0 -3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 6912 0 -1 0 -6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3456 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 3200 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="73" owner="0" type="0" pos="27 23 -33.5" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 23 0 0 1 -33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2944 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3456 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3456 0 -1 0 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 6912 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3456 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2944 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="74" owner="0" type="0" pos="27 17 -33.5" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 17 0 0 1 -33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2176 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3456 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3456 0 -1 0 -2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 6912 0 -1 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3456 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2176 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="75" owner="0" type="0" pos="21 23 -33.5" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 23 0 0 1 -33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2944 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2688 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2688 0 -1 0 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5376 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2688 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2944 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="76" owner="0" type="0" pos="23 23 -32.75" rot="1 0 0 0" scale="" transform="1 0 0 23 0 1 0 23 0 0 1 -32.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 -1 -0.75" />
                            <Vertex pos="-1 1 -0.75" />
                            <Vertex pos="1 -1 0.75" />
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2944 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.447214 0 0.894427 -0.223607" album="Blasted" material="bm_friction_ice" texgens="1 0 0 5888 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2944 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2944 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2944 0 1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2944 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="77" owner="0" type="0" pos="25 23 -32.75" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 23 0 0 1 -32.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="-1 -1 0.750002" />
                            <Vertex pos="-1 1 0.750002" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="1 1 -0.75" />
                            <Vertex pos="1 -1 -0.249996" />
                            <Vertex pos="1 1 -0.249996" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2944 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.447214 -0 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3200 0 1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3200 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3200 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0.447213 -0 0.894428 -0.22361" album="Blasted" material="bm_friction_ice" texgens="1 0 0 6400 0 -1 0 -5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2944 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="78" owner="0" type="0" pos="27 21 -32.75" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 21 0 0 1 -32.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 0.250004" />
                            <Vertex pos="-1 -1 0.75" />
                            <Vertex pos="-1 1 -0.749996" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="1 -1 0.250004" />
                            <Vertex pos="1 -1 0.75" />
                            <Vertex pos="1 1 -0.749996" />
                            <Vertex pos="1 1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2688 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3456 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.447214 -0.894427 -0.223603" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3456 0 1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.447214 0.894427 -0.223607" album="Blasted" material="bm_friction_ice" texgens="1 0 0 6912 0 -1 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3456 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2688 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="79" owner="0" type="0" pos="27 19 -32.75" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 19 0 0 1 -32.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.249996" />
                            <Vertex pos="-1 -1 -0.75" />
                            <Vertex pos="-1 1 0.750002" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.249996" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="1 1 0.750002" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -2432 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3456 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.447213 0.894428 -0.22361" album="Blasted" material="bm_friction_ice" texgens="1 0 0 6912 0 -1 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3456 0 1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3456 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 2432 0 0 -1 4192 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="80" owner="0" type="0" pos="7 15 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 15 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 0.250004" />
                            <Vertex pos="-1 -1 0.75" />
                            <Vertex pos="-1 1 -0.749996" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="1 -1 0.250004" />
                            <Vertex pos="1 -1 0.75" />
                            <Vertex pos="1 1 -0.749996" />
                            <Vertex pos="1 1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1920 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.447214 -0.894427 -0.223603" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 896 0 1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.447214 0.894427 -0.223607" album="Blasted" material="bm_friction_ice" texgens="1 0 0 1792 0 -1 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -896 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1920 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="81" owner="0" type="0" pos="7 13 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 13 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 -0.75" />
                            <Vertex pos="-1 1 0.75" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1664 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 896 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.447214 0.894427 -0.223607" album="Blasted" material="bm_friction_ice" texgens="1 0 0 1792 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 896 0 1 0 1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -896 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1664 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="82" owner="0" type="0" pos="13 11 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 11 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.249996" />
                            <Vertex pos="-1 1 -0.249996" />
                            <Vertex pos="-1 -1 -0.75" />
                            <Vertex pos="-1 1 -0.75" />
                            <Vertex pos="1 -1 0.750004" />
                            <Vertex pos="1 1 0.750004" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.447214 0 0.894427 -0.22361" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3328 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1664 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.447214 0 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="83" owner="0" type="0" pos="15 11 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 11 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 0.250004" />
                            <Vertex pos="-1 1 0.250004" />
                            <Vertex pos="-1 -1 0.749996" />
                            <Vertex pos="-1 1 0.749996" />
                            <Vertex pos="1 -1 -0.749996" />
                            <Vertex pos="1 1 -0.749996" />
                            <Vertex pos="1 -1 -0.250004" />
                            <Vertex pos="1 1 -0.250004" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.447214 -0 -0.894427 -0.223603" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1920 0 1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1920 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1920 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0.447214 -0 0.894427 -0.223603" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3840 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1408 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="84" owner="0" type="0" pos="52 14 -20" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 14 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -22 -4" />
                            <Vertex pos="-2 -14 4" />
                            <Vertex pos="-4 22 -4" />
                            <Vertex pos="-2 14 4" />
                            <Vertex pos="4 -22 -4" />
                            <Vertex pos="4 -14 4" />
                            <Vertex pos="4 22 -4" />
                            <Vertex pos="4 14 4" />
                        </Vertices>
                        <Face id="0" plane="-0.970142 0 0.242536 -2.91043" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3584 0 0 -1 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -0.707107 -0.707107 543.058 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0.707107 -0.707107 3077.33 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="85" owner="0" type="0" pos="52 14 16" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 14 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -14 -4" />
                            <Vertex pos="-4 -22 4" />
                            <Vertex pos="-2 14 -4" />
                            <Vertex pos="-4 22 4" />
                            <Vertex pos="4 -14 -4" />
                            <Vertex pos="4 -22 4" />
                            <Vertex pos="4 14 -4" />
                            <Vertex pos="4 22 4" />
                        </Vertices>
                        <Face id="0" plane="-0.970142 0 -0.242536 -2.91043" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3584 0 0 -1 -4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0.707107 -0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0.707107 -0.707107 -181.019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.707107 -0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -0.707107 -0.707107 -2715.29 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="86" owner="0" type="0" pos="52 32 -2" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 32 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -4 14" />
                            <Vertex pos="-2 -4 -14" />
                            <Vertex pos="-4 4 22" />
                            <Vertex pos="-4 4 -22" />
                            <Vertex pos="4 -4 14" />
                            <Vertex pos="4 -4 -14" />
                            <Vertex pos="4 4 22" />
                            <Vertex pos="4 4 -22" />
                        </Vertices>
                        <Face id="0" plane="-0.970142 -0.242536 -0 -2.91043" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -8192 0 0 -1 512.001 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -0.707107 -0.707107 -2715.29 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 -0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0.707107 -0.707107 3077.33 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 -0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 4096 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="87" owner="0" type="0" pos="52 -4 -2" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 -4 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -4 22" />
                            <Vertex pos="-4 -4 -22" />
                            <Vertex pos="-2 4 14" />
                            <Vertex pos="-2 4 -14" />
                            <Vertex pos="4 -4 22" />
                            <Vertex pos="4 -4 -22" />
                            <Vertex pos="4 4 14" />
                            <Vertex pos="4 4 -14" />
                        </Vertices>
                        <Face id="0" plane="-0.970142 0.242536 0 -2.91043" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 1024 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 0.707107 0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0.707107 -0.707107 -181.019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707107 -0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -0.707107 -0.707107 543.058 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -512 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="88" owner="0" type="0" pos="53 14 -2" rot="1 0 0 0" scale="" transform="1 0 0 53 0 1 0 14 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -14 -14" />
                            <Vertex pos="-3 -14 14" />
                            <Vertex pos="-3 14 -14" />
                            <Vertex pos="-3 14 14" />
                            <Vertex pos="3 -14 -14" />
                            <Vertex pos="3 -14 14" />
                            <Vertex pos="3 14 -14" />
                            <Vertex pos="3 14 14" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -3" album="Blasted" material="bm_tile08_B" texgens="0 -1 0 -3584 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -14" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6784 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -14" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6784 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -14" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6784 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -14" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6784 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -3" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="89" owner="0" type="0" pos="49.75 20 7" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 20 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.750004 -2 -1" />
                            <Vertex pos="0.249996 -4 1" />
                            <Vertex pos="-0.750004 2 -1" />
                            <Vertex pos="0.249996 4 1" />
                            <Vertex pos="-0.249996 -2 -1" />
                            <Vertex pos="0.750004 -4 1" />
                            <Vertex pos="-0.249996 2 -1" />
                            <Vertex pos="0.750004 4 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -5120 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0.707107 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.707107 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -2443.76 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0 -0.447214 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2560 -0.447214 0 -0.894427 -3649.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="90" owner="0" type="0" pos="49.75 22 0.999999" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 22 0 0 1 0.999999 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.250004 -2 -0.999999" />
                            <Vertex pos="-0.749996 -1.90735e-006 0.999999" />
                            <Vertex pos="0.250004 2 -0.999999" />
                            <Vertex pos="0.749996 -2 -0.999999" />
                            <Vertex pos="-0.250004 -1.90735e-006 0.999999" />
                            <Vertex pos="0.749996 2 -0.999999" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223603" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -5632 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -2081.72 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.999999" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707106 0.707107 -0.707105" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 1900.7 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 -0 0.447214 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2816 0.447214 0 -0.894427 2733.37 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="91" owner="0" type="0" pos="49.75 17 6" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 17 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.250004 -1 -2" />
                            <Vertex pos="0.250004 -1 2" />
                            <Vertex pos="-0.749996 0.999998 4.76837e-007" />
                            <Vertex pos="0.749996 -1 -2" />
                            <Vertex pos="0.749996 -1 2" />
                            <Vertex pos="-0.25 0.999998 4.76837e-007" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223604" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -4352 0 0 -1 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707106 -0.707105" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -2081.72 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707106 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 995.607 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894428 0.447213 -0 -0.223605" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -901.586 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="92" owner="0" type="0" pos="49.75 23 4" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 23 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.75 -1 -2" />
                            <Vertex pos="-0.75 -1 2" />
                            <Vertex pos="0.249996 1 -4" />
                            <Vertex pos="0.249996 1 4" />
                            <Vertex pos="-0.249992 -1 -2" />
                            <Vertex pos="-0.249992 -1 2" />
                            <Vertex pos="0.750004 1 -4" />
                            <Vertex pos="0.750004 1 4" />
                        </Vertices>
                        <Face id="0" plane="-0.894428 0.447212 0 -0.223609" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -5888 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 1719.68 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -2443.76 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894428 -0.447212 0 -0.223612" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 5481.05 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="93" owner="0" type="0" pos="49.75 6 7" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 6 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 1" />
                            <Vertex pos="-0.75 4.76837e-007 -1" />
                            <Vertex pos="0.25 2 1" />
                            <Vertex pos="0.75 -2 1" />
                            <Vertex pos="-0.25 4.76837e-007 -1" />
                            <Vertex pos="0.75 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1536 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 -90.5098 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 -0.447214 0 -0.894427 -3649.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="94" owner="0" type="0" pos="49.75 6 5" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 6 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 -1" />
                            <Vertex pos="-0.75 0 1" />
                            <Vertex pos="0.25 2 -1" />
                            <Vertex pos="0.75 -2 -1" />
                            <Vertex pos="-0.249996 0 1" />
                            <Vertex pos="0.75 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1536 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -995.607 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 90.5097 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894428 -0 0.447212 -0.223609" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 0.447214 0 -0.894427 2275.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="95" owner="0" type="0" pos="49.75 5 6" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 5 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -1 -2" />
                            <Vertex pos="0.25 -1 2" />
                            <Vertex pos="-0.75 1 0" />
                            <Vertex pos="0.75 -1 -2" />
                            <Vertex pos="0.75 -1 2" />
                            <Vertex pos="-0.249996 1 0" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1280 0 0 -1 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -995.606 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 -90.5097 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894428 0.447212 -0 -0.223609" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -2275.43 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="96" owner="0" type="0" pos="49.75 7 6" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 7 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 -1 4.76837e-007" />
                            <Vertex pos="0.25 1 -2" />
                            <Vertex pos="0.25 1 2" />
                            <Vertex pos="-0.25 -1 4.76837e-007" />
                            <Vertex pos="0.75 1 -2" />
                            <Vertex pos="0.75 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1792 0 0 -1 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 90.5098 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -0.447214 0 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 3649.27 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="97" owner="0" type="0" pos="49.75 20 5" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 20 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -4 -1" />
                            <Vertex pos="-0.75 -2 1" />
                            <Vertex pos="0.25 4 -1" />
                            <Vertex pos="-0.75 2 1" />
                            <Vertex pos="0.75 -4 -1" />
                            <Vertex pos="-0.25 -2 1" />
                            <Vertex pos="0.75 4 -1" />
                            <Vertex pos="-0.25 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -5120 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -2262.74 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 1357.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0 0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2560 0.447214 0 -0.894427 2275.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="98" owner="0" type="0" pos="49.75 21 4" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 21 0 0 1 4 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -1 -4" />
                            <Vertex pos="0.25 -1 4" />
                            <Vertex pos="-0.75 1 -2" />
                            <Vertex pos="-0.75 1 2" />
                            <Vertex pos="0.750004 -1 -4" />
                            <Vertex pos="0.750004 -1 4" />
                            <Vertex pos="-0.249996 1 -2" />
                            <Vertex pos="-0.249996 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -5376 0 0 -1 -1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -2262.74 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 1538.66 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0.447214 -0 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -443.639 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="99" owner="0" type="0" pos="49.75 14 -0.999999" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 14 0 0 1 -0.999999 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.250004 -2 0.999999" />
                            <Vertex pos="-0.749996 0 -0.999999" />
                            <Vertex pos="0.250004 2 0.999999" />
                            <Vertex pos="0.749996 -2 0.999999" />
                            <Vertex pos="-0.25 0 -0.999999" />
                            <Vertex pos="0.749996 2 0.999999" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.223603" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3584 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707106 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 1357.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -0.999999" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707106 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894428 0 -0.447213 -0.223605" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 -0.447214 0 -0.894427 -2733.37 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="100" owner="0" type="0" pos="49.75 13 -6" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 13 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -1 -6" />
                            <Vertex pos="0.25 -1 6" />
                            <Vertex pos="-0.75 1 -4" />
                            <Vertex pos="-0.75 1 4" />
                            <Vertex pos="0.750004 -1 -6" />
                            <Vertex pos="0.750004 -1 6" />
                            <Vertex pos="-0.249996 1 -4" />
                            <Vertex pos="-0.249996 1 4" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3328 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -633.568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 1719.68 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0.447214 -0 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -1359.53 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="101" owner="0" type="0" pos="49.75 15 -6" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 15 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.75 -0.999999 -4" />
                            <Vertex pos="-0.75 -0.999999 4" />
                            <Vertex pos="0.249996 1 -6" />
                            <Vertex pos="0.249996 1 6" />
                            <Vertex pos="-0.250004 -1 -4" />
                            <Vertex pos="-0.250004 -1 4" />
                            <Vertex pos="0.749996 1 -6" />
                            <Vertex pos="0.749996 1 6" />
                        </Vertices>
                        <Face id="0" plane="-0.894428 0.447212 0 -0.223609" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3840 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-2.02657e-006 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 1900.7 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-1.433e-006 -0.707106 0.707107 -3.53554" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -814.587 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 -0.447214 0 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 4565.16 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="102" owner="0" type="0" pos="49.75 14 -11" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 14 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 -1" />
                            <Vertex pos="-0.75 0 1" />
                            <Vertex pos="0.25 2 -1" />
                            <Vertex pos="0.75 -2 -1" />
                            <Vertex pos="-0.250004 9.53674e-007 1" />
                            <Vertex pos="0.75 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3584 0 0 -1 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -271.529 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="-1.34871e-006 0.707107 0.707106 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 2262.74 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 -0 0.447215 -0.223605" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0.447214 0 -0.894427 4107.21 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="103" owner="0" type="0" pos="49.75 29 -5" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 29 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.749996 -3 -1" />
                            <Vertex pos="0.250004 -5 1" />
                            <Vertex pos="-0.749996 3 -1" />
                            <Vertex pos="0.250004 5 1" />
                            <Vertex pos="-0.249996 -3 -1" />
                            <Vertex pos="0.75 -5 1" />
                            <Vertex pos="-0.25 3 -1" />
                            <Vertex pos="0.75 5 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.223603" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -7424 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0.707107 -0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 3077.33 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.707107 -0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -2172.23 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 5.95317e-007 -0.447214 -0.223609" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 3712 -0.447214 0 -0.894427 -2275.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="104" owner="0" type="0" pos="49.75 29 -7" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 29 0 0 1 -7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.249992 -5 -1" />
                            <Vertex pos="-0.750008 -3 1" />
                            <Vertex pos="0.249992 5 -1" />
                            <Vertex pos="-0.750008 3 1" />
                            <Vertex pos="0.750004 -5 -1" />
                            <Vertex pos="-0.249996 -3 1" />
                            <Vertex pos="0.750008 5 -1" />
                            <Vertex pos="-0.249992 3 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223614" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -7424 0 0 -1 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -1991.21 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -3712 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 3258.35 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 -3.57191e-007 0.447213 -0.223613" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 3712 0.447214 0 -0.894427 3649.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="105" owner="0" type="0" pos="49.75 25 -6" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 25 0 0 1 -6 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.249996 -1 -2" />
                            <Vertex pos="0.249996 -1 2" />
                            <Vertex pos="-0.75 0.999996 4.76837e-007" />
                            <Vertex pos="0.750004 -1 -2" />
                            <Vertex pos="0.750004 -1 2" />
                            <Vertex pos="-0.249992 0.999998 -4.76837e-007" />
                        </Vertices>
                        <Face id="0" plane="-0.894428 -0.447213 -0 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -6400 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="-4.13032e-006 0.707107 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -1719.68 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707106 -0.707105" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 2805.8 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894428 0.447213 -0 -0.223612" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 14.3076 0 0 -1 768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="106" owner="0" type="0" pos="49.75 4 -1" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 4 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.250004 -2 1" />
                            <Vertex pos="-0.749996 -2.38419e-007 -1" />
                            <Vertex pos="0.250004 2 1" />
                            <Vertex pos="0.749996 -2 1" />
                            <Vertex pos="-0.250004 -2.38419e-007 -1" />
                            <Vertex pos="0.749996 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.223603" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1024 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 452.548 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -271.529 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 0 -0.447214 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 512 -0.447214 0 -0.894427 -2733.37 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="107" owner="0" type="0" pos="49.75 4 -3" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 4 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 -1" />
                            <Vertex pos="-0.75 0 1" />
                            <Vertex pos="0.25 2 -1" />
                            <Vertex pos="0.75 -2 -1" />
                            <Vertex pos="-0.25 0 1" />
                            <Vertex pos="0.75 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1024 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -90.5097 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 633.568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 -0 0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 512 0.447214 0 -0.894427 3191.32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="108" owner="0" type="0" pos="49.75 3 -2" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 3 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -1 -2" />
                            <Vertex pos="0.25 -1 2" />
                            <Vertex pos="-0.75 1 1.19209e-007" />
                            <Vertex pos="0.750004 -1 -2" />
                            <Vertex pos="0.750004 -1 2" />
                            <Vertex pos="-0.249996 1 1.19209e-007" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -768 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -90.5097 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 452.548 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 0.447214 -0 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -2504.4 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="109" owner="0" type="0" pos="49.75 5 -2" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 5 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 -1 -1.19209e-007" />
                            <Vertex pos="0.25 1 -2" />
                            <Vertex pos="0.25 1 2" />
                            <Vertex pos="-0.250004 -1 -1.19209e-007" />
                            <Vertex pos="0.749996 1 -2" />
                            <Vertex pos="0.749996 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1280 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 633.568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -271.529 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -0.447214 0 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 3420.29 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="110" owner="0" type="0" pos="49.75 20 -11" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 20 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 1" />
                            <Vertex pos="-0.75 -1.90735e-006 -0.999999" />
                            <Vertex pos="0.25 2 1" />
                            <Vertex pos="0.749996 -2 1" />
                            <Vertex pos="-0.25 -1.90735e-006 -0.999998" />
                            <Vertex pos="0.75 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -5120 0 0 -1 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="1.43299e-006 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 2805.8 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707106 -0.707107 -0.707105" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -814.587 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -8.92977e-007 -0.447213 -0.223606" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2560 -0.447214 0 -0.894427 -1588.51 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="111" owner="0" type="0" pos="49.75 20 -13" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 20 0 0 1 -13 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 -1" />
                            <Vertex pos="-0.75 0 1" />
                            <Vertex pos="0.25 2 -1" />
                            <Vertex pos="0.75 -2 -1" />
                            <Vertex pos="-0.25 0 1" />
                            <Vertex pos="0.75 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -5120 0 0 -1 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -633.568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 2986.82 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 -0 0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2560 0.447214 0 -0.894427 4336.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="112" owner="0" type="0" pos="49.75 19 -12" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 19 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.249996 -1 -2" />
                            <Vertex pos="0.249996 -1 2" />
                            <Vertex pos="-0.750004 0.999998 0" />
                            <Vertex pos="0.75 -1 -2" />
                            <Vertex pos="0.75 -1 2" />
                            <Vertex pos="-0.25 0.999998 0" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223611" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -4864 0 0 -1 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707106 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -633.568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707106 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 2805.8 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 0.447214 -0 -0.223606" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -672.612 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="113" owner="0" type="0" pos="49.75 21 -12" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 21 0 0 1 -12 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 -1 -9.53674e-007" />
                            <Vertex pos="0.250004 1 -2" />
                            <Vertex pos="0.250004 1 2" />
                            <Vertex pos="-0.249996 -1 -9.53674e-007" />
                            <Vertex pos="0.75 1 -2" />
                            <Vertex pos="0.75 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447215 0 -0.223605" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -5376 0 0 -1 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 2986.82 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -814.587 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894428 -0.447212 0 -0.223609" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 5252.08 0 0 -1 1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="114" owner="0" type="0" pos="49.75 6 -9" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 6 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.249996 -2 1" />
                            <Vertex pos="-0.75 4.76837e-007 -0.999999" />
                            <Vertex pos="0.249996 2 1" />
                            <Vertex pos="0.749996 -2 1" />
                            <Vertex pos="-0.250004 0 -0.999999" />
                            <Vertex pos="0.749996 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894428 0 0.447212 -0.223609" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1536 0 0 -1 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-6.74355e-007 -0.707107 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 1357.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707107 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 271.529 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 0 -0.447214 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 -0.447214 0 -0.894427 -1817.48 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="115" owner="0" type="0" pos="49.75 6 -11" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 6 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 -1" />
                            <Vertex pos="-0.75 4.76837e-007 1" />
                            <Vertex pos="0.25 2 -1" />
                            <Vertex pos="0.75 -2 -1" />
                            <Vertex pos="-0.25 4.76837e-007 1" />
                            <Vertex pos="0.75 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1536 0 0 -1 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 452.549 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 1538.66 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 -0 0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 0.447214 0 -0.894427 4107.21 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="116" owner="0" type="0" pos="49.75 5 -10" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 5 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -1 -2" />
                            <Vertex pos="0.25 -1 2" />
                            <Vertex pos="-0.75 1 0" />
                            <Vertex pos="0.75 -1 -2" />
                            <Vertex pos="0.75 -1 2" />
                            <Vertex pos="-0.25 1 0" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1280 0 0 -1 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 452.548 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 1357.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 0.447214 -0 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -2275.43 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="117" owner="0" type="0" pos="49.75 7 -10" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 7 0 0 1 -10 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 -1 0" />
                            <Vertex pos="0.25 1 -2" />
                            <Vertex pos="0.25 1 2" />
                            <Vertex pos="-0.25 -1 0" />
                            <Vertex pos="0.75 1 -2" />
                            <Vertex pos="0.75 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1792 0 0 -1 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 1538.66 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 271.529 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -0.447214 0 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 3649.27 0 0 -1 1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="118" owner="0" type="0" pos="52 14 -32" rot="1 0 0 0" scale="" transform="1 0 0 52 0 1 0 14 0 0 1 -32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -22 -8" />
                            <Vertex pos="-4 -22 8" />
                            <Vertex pos="-4 22 -8" />
                            <Vertex pos="-4 22 8" />
                            <Vertex pos="4 -22 -8" />
                            <Vertex pos="4 -22 8" />
                            <Vertex pos="4 22 -8" />
                            <Vertex pos="4 22 8" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_tile08_B" texgens="0 -1 0 -448 0 0 -1 1024 0 1 1" texRot="0" texScale="1 1" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -22" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -8" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6656 0 -1 0 -1792 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -22" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6656 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1792 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="119" owner="0" type="0" pos="49.75 12 7" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 12 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.249996 -2 -1" />
                            <Vertex pos="-0.750004 0 1" />
                            <Vertex pos="0.249996 2 -1" />
                            <Vertex pos="0.750004 -2 -1" />
                            <Vertex pos="-0.249996 0 1" />
                            <Vertex pos="0.750004 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3072 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -1719.68 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 452.548 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 -0 0.447214 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1536 0.447214 0 -0.894427 2046.45 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="120" owner="0" type="0" pos="49.75 11 12" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 11 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -1 -6" />
                            <Vertex pos="0.25 -1 6" />
                            <Vertex pos="-0.75 1 -4" />
                            <Vertex pos="-0.75 1 4" />
                            <Vertex pos="0.75 -1 -6" />
                            <Vertex pos="0.75 -1 6" />
                            <Vertex pos="-0.250004 1 -4" />
                            <Vertex pos="-0.250004 1 4" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -2816 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -2081.72 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 -90.5096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0.447215 -0 -0.223605" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -1588.51 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="121" owner="0" type="0" pos="49.75 13 12" rot="1 0 0 0" scale="" transform="1 0 0 49.75 0 1 0 13 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.75 -1 -4" />
                            <Vertex pos="-0.75 -1 4" />
                            <Vertex pos="0.25 1 -6" />
                            <Vertex pos="0.25 1 6" />
                            <Vertex pos="-0.25 -1 -4" />
                            <Vertex pos="-0.25 -1 4" />
                            <Vertex pos="0.75 1 -6" />
                            <Vertex pos="0.75 1 6" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3328 0 0 -1 -3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 90.5098 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -2262.74 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 -0.447214 0 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 4336.19 0 0 -1 -1536 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="122" owner="0" type="0" pos="18 48 16" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 48 0 0 1 16 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14 -2 -4" />
                            <Vertex pos="-22 -4 4" />
                            <Vertex pos="-14 4 -4" />
                            <Vertex pos="-22 4 4" />
                            <Vertex pos="14 -2 -4" />
                            <Vertex pos="22 -4 4" />
                            <Vertex pos="14 4 -4" />
                            <Vertex pos="22 4 4" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 0 -0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0.707107 0 -0.707107 181.02 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0.970142 -0.242536 -2.91043" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4608 0 0 -1 -4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 2304 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 -2048 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 -0.707107 0 -0.707107 -3077.33 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="123" owner="0" type="0" pos="18 48 -20" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 48 0 0 1 -20 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-22 -4 -4" />
                            <Vertex pos="-14 -2 4" />
                            <Vertex pos="-22 4 -4" />
                            <Vertex pos="-14 4 4" />
                            <Vertex pos="22 -4 -4" />
                            <Vertex pos="14 -2 4" />
                            <Vertex pos="22 4 -4" />
                            <Vertex pos="14 4 4" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 0 0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 -0.707107 0 -0.707107 181.019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.970142 0.242536 -2.91043" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4608 0 0 -1 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 2304 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0.707107 0 -0.707107 3439.37 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="124" owner="0" type="0" pos="0 48 -2" rot="1 0 0 0" scale="" transform="1 0 0 0 0 1 0 48 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 4 -22" />
                            <Vertex pos="-4 4 22" />
                            <Vertex pos="-4 -4 -22" />
                            <Vertex pos="-4 -4 22" />
                            <Vertex pos="4 4 -14" />
                            <Vertex pos="4 4 14" />
                            <Vertex pos="4 -2 -14" />
                            <Vertex pos="4 -2 14" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 0 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0.242536 -0.970142 0 -2.91043" album="Blasted" material="bm_friction_ice" texgens="1 0 0 0 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0.707107 0 -0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 -0.707107 0 -0.707107 181.019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0.707107 -0 0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0.707107 0 -0.707107 181.019 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="125" owner="0" type="0" pos="36 48 -2" rot="1 0 0 0" scale="" transform="1 0 0 36 0 1 0 48 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -2 -14" />
                            <Vertex pos="-4 4 -14" />
                            <Vertex pos="-4 -2 14" />
                            <Vertex pos="-4 4 14" />
                            <Vertex pos="4 -4 -22" />
                            <Vertex pos="4 4 -22" />
                            <Vertex pos="4 -4 22" />
                            <Vertex pos="4 4 22" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0 -0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0.707107 0 -0.707107 3439.37 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-0.707107 0 0.707107 -12.7279" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 -0.707107 0 -0.707107 -3077.33 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="-0.242536 -0.970142 0 -2.91043" album="Blasted" material="bm_friction_ice" texgens="1 0 0 9216 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -4608 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="126" owner="0" type="0" pos="18 49 -2" rot="1 0 0 0" scale="" transform="1 0 0 18 0 1 0 49 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-14 -3 -14" />
                            <Vertex pos="-14 -3 14" />
                            <Vertex pos="-14 3 -14" />
                            <Vertex pos="-14 3 14" />
                            <Vertex pos="14 -3 -14" />
                            <Vertex pos="14 -3 14" />
                            <Vertex pos="14 3 -14" />
                            <Vertex pos="14 3 14" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -14" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6272 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="Blasted" material="bm_tile01_B" texgens="1 0 0 4608 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -14" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 -1 0 -6272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -14" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 2304 0 -1 0 -6272 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -3" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2304 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -14" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6272 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="127" owner="0" type="0" pos="11 45.75 -9" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 45.75 0 0 1 -9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -0.25 -0.999994" />
                            <Vertex pos="-3 -0.25 0.999994" />
                            <Vertex pos="-3.5 0.25 -1.5" />
                            <Vertex pos="-3.5 0.25 1.49999" />
                            <Vertex pos="3 -0.249996 -0.999998" />
                            <Vertex pos="3 -0.249996 0.999997" />
                            <Vertex pos="3.5 0.25 -1.5" />
                            <Vertex pos="3.5 0.25 1.49999" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -2.2981" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="6.65585e-007 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 -2304 1 0 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707111 -0.707103 -0.883876" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.12389e-007 -0.707105 0.707109 -0.88388" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -2.29809" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="128" owner="0" type="0" pos="10 45.75 1" rot="1 0 0 0" scale="" transform="1 0 0 10 0 1 0 45.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -0.25 -0.999996" />
                            <Vertex pos="-2 -0.25 0.999996" />
                            <Vertex pos="-2.5 0.25 -1.5" />
                            <Vertex pos="-2.5 0.25 1.5" />
                            <Vertex pos="2 -0.249996 -0.999999" />
                            <Vertex pos="2 -0.249996 0.999997" />
                            <Vertex pos="2.5 0.25 -1.5" />
                            <Vertex pos="2.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="9.98378e-007 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 256 1 0 0 2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.70711 -0.707104 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="5.26842e-007 -0.707112 0.707102 -0.883876" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -1.59098" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="129" owner="0" type="0" pos="15 45.75 -1" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 45.75 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -0.25 -0.999996" />
                            <Vertex pos="-3 -0.25 0.999996" />
                            <Vertex pos="-3.5 0.25 -1.5" />
                            <Vertex pos="-3.5 0.25 1.5" />
                            <Vertex pos="3 -0.249996 -0.999997" />
                            <Vertex pos="3 -0.249996 0.999999" />
                            <Vertex pos="3.5 0.25 -1.5" />
                            <Vertex pos="3.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -2.2981" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="6.65585e-007 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 -256 1 0 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.70711 -0.707104 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.1942e-007 -0.70711 0.707103 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -2.29809" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="130" owner="0" type="0" pos="21 45.75 -11" rot="1 0 0 0" scale="" transform="1 0 0 21 0 1 0 45.75 0 0 1 -11 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999996 -0.25 -0.999997" />
                            <Vertex pos="-0.999996 -0.25 0.999997" />
                            <Vertex pos="-1.5 0.25 -1.5" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="1 -0.249996 -0.999998" />
                            <Vertex pos="1 -0.249996 0.999997" />
                            <Vertex pos="1.5 0.25 -1.5" />
                            <Vertex pos="1.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707104 -0.70711 -0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1.99676e-006 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 -2816 1 0 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707109 -0.707105 -0.88388" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.41193e-006 -0.707112 0.707101 -0.883876" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 384 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="131" owner="0" type="0" pos="25 45.75 -5" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 45.75 0 0 1 -5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -0.25 -0.999997" />
                            <Vertex pos="-3 -0.25 0.999997" />
                            <Vertex pos="-3.5 0.25 -1.5" />
                            <Vertex pos="-3.5 0.25 1.5" />
                            <Vertex pos="3 -0.249996 -1" />
                            <Vertex pos="3 -0.249996 0.999999" />
                            <Vertex pos="3.5 0.25 -1.5" />
                            <Vertex pos="3.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -2.2981" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="6.65585e-007 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 -1280 1 0 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707109 -0.707105 -0.88388" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="2.38836e-007 -0.70711 0.707103 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -2.29809" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="132" owner="0" type="0" pos="29 45.75 -8" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 45.75 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -0.250004 -4" />
                            <Vertex pos="-1 -0.250004 4" />
                            <Vertex pos="-1.5 0.249996 -4.5" />
                            <Vertex pos="-1.5 0.249996 4.5" />
                            <Vertex pos="1 -0.25 -4" />
                            <Vertex pos="1 -0.25 4" />
                            <Vertex pos="1.5 0.25 -4.5" />
                            <Vertex pos="1.5 0.25 4.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -0.883886" album="Blasted" material="bm_edge_white" texgens="0 1 0 64.001 0 0 1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1.99676e-006 -1 0 -0.250002" album="Blasted" material="bm_friction_ice" texgens="0 0 1 -2048 1 0 0 7424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="9.41279e-007 -0.707106 -0.707107 -3.00521" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.41192e-006 -0.707107 0.707106 -3.0052" album="Blasted" material="bm_edge_white" texgens="0 1 0 64.001 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-1.33117e-006 1 0 -0.249998" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1152 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 -0.707107 0 -0.883883" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="133" owner="0" type="0" pos="25 45.75 -2" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 45.75 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999998 -0.25 -2" />
                            <Vertex pos="-0.999998 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.5" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="1 -0.249996 -2" />
                            <Vertex pos="1 -0.249996 2" />
                            <Vertex pos="1.5 0.25 -2.5" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707105 -0.707108 -0 -0.883881" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1.99676e-006 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 -511.999 1 0 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.41193e-006 -0.70711 0.707103 -1.59098" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 639.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="134" owner="0" type="0" pos="29 45.75 9" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 45.75 0 0 1 9 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999998 -0.25 -0.999994" />
                            <Vertex pos="-0.999998 -0.25 0.999994" />
                            <Vertex pos="-1.5 0.25 -1.49999" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="1 -0.249996 -0.999997" />
                            <Vertex pos="1 -0.249996 0.999998" />
                            <Vertex pos="1.5 0.25 -1.49999" />
                            <Vertex pos="1.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707105 -0.707108 -0 -0.883881" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1.99676e-006 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 2304 1 0 0 7424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707104 -0.70711 -0.883881" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.70425e-011 -0.707111 0.707103 -0.883876" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="135" owner="0" type="0" pos="17 45.75 7" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 45.75 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999992 -0.25 -3" />
                            <Vertex pos="-0.999992 -0.25 3" />
                            <Vertex pos="-1.49999 0.25 -3.5" />
                            <Vertex pos="-1.49999 0.25 3.5" />
                            <Vertex pos="0.999996 -0.249996 -3" />
                            <Vertex pos="0.999996 -0.249996 3" />
                            <Vertex pos="1.49999 0.25 -3.5" />
                            <Vertex pos="1.49999 0.25 3.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707108 -0.707105 -0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1.99677e-006 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 1792 1 0 0 4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -2.2981" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.41193e-006 -0.70711 0.707103 -2.29809" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 895.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707108 -0.707105 0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="136" owner="0" type="0" pos="20 45.75 5" rot="1 0 0 0" scale="" transform="1 0 0 20 0 1 0 45.75 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -0.25 -0.999997" />
                            <Vertex pos="-2 -0.25 0.999997" />
                            <Vertex pos="-2.5 0.25 -1.5" />
                            <Vertex pos="-2.5 0.25 1.5" />
                            <Vertex pos="2 -0.249996 -0.999999" />
                            <Vertex pos="2 -0.249996 1" />
                            <Vertex pos="2.5 0.25 -1.5" />
                            <Vertex pos="2.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="9.98378e-007 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 1280 1 0 0 5120 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707109 -0.707105 -0.88388" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.79129e-007 -0.70711 0.707104 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -1.59098" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="137" owner="0" type="0" pos="11 45.75 10" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 45.75 0 0 1 10 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -0.250004 -3.99999" />
                            <Vertex pos="-1 -0.250004 3.99999" />
                            <Vertex pos="-1.5 0.249996 -4.5" />
                            <Vertex pos="-1.5 0.249996 4.5" />
                            <Vertex pos="0.999999 -0.25 -3.99999" />
                            <Vertex pos="0.999999 -0.25 4" />
                            <Vertex pos="1.5 0.25 -4.5" />
                            <Vertex pos="1.5 0.25 4.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -0.883886" album="Blasted" material="bm_edge_white" texgens="0 1 0 64.001 0 0 1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1.99676e-006 -1 0 -0.250002" album="Blasted" material="bm_friction_ice" texgens="0 0 1 2560 1 0 0 2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="9.41288e-007 -0.707113 -0.7071 -3.00517" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-2.12842e-006 -0.707106 0.707108 -3.00521" album="Blasted" material="bm_edge_white" texgens="0 1 0 64.001 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-1.33117e-006 1 0 -0.249998" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1152 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707106 -0.707107 0 -0.883882" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="138" owner="0" type="0" pos="27 45.75 1" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 45.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999996 -0.25 -0.999996" />
                            <Vertex pos="-0.999996 -0.25 0.999996" />
                            <Vertex pos="-1.5 0.25 -1.5" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="0.999998 -0.249996 -0.999999" />
                            <Vertex pos="0.999998 -0.249996 0.999997" />
                            <Vertex pos="1.5 0.25 -1.5" />
                            <Vertex pos="1.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707104 -0.70711 -0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1.99676e-006 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 256 1 0 0 6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.70711 -0.707104 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.05369e-006 -0.707112 0.707101 -0.883875" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707103 -0.707111 0 -0.883876" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="139" owner="0" type="0" pos="7 45.75 -3" rot="1 0 0 0" scale="" transform="1 0 0 7 0 1 0 45.75 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999997 -0.25 -0.999996" />
                            <Vertex pos="-0.999997 -0.25 0.999996" />
                            <Vertex pos="-1.5 0.25 -1.5" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="0.999999 -0.249996 -0.999996" />
                            <Vertex pos="0.999999 -0.249996 0.999996" />
                            <Vertex pos="1.5 0.25 -1.5" />
                            <Vertex pos="1.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707105 -0.707109 -0 -0.88388" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="1.99676e-006 -1 0 -0.249998" album="Blasted" material="bm_friction_ice" texgens="0 0 1 -767.999 1 0 0 1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.70711 -0.707104 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="1.41193e-006 -0.707113 0.7071 -0.883874" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707103 -0.70711 0 -0.883877" album="Blasted" material="bm_edge_white" texgens="0 1 0 63.999 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="140" owner="0" type="0" pos="26 48 -32" rot="1 0 0 0" scale="" transform="1 0 0 26 0 1 0 48 0 0 1 -32 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-30 -4 -8" />
                            <Vertex pos="-30 -4 8" />
                            <Vertex pos="-30 4 -8" />
                            <Vertex pos="-30 4 8" />
                            <Vertex pos="30 -4 -8" />
                            <Vertex pos="30 -4 8" />
                            <Vertex pos="30 4 -8" />
                            <Vertex pos="30 4 8" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -30" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_tile01_B" texgens="1 0 0 6656 0 0 -1 8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -8" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -8" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 3328 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3328 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -30" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0 0 -1 4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="141" owner="0" type="0" pos="48 48 -2" rot="1 0 0 0" scale="" transform="1 0 0 48 0 1 0 48 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-8 -4 -22" />
                            <Vertex pos="-8 -4 22" />
                            <Vertex pos="-8 4 -22" />
                            <Vertex pos="-8 4 22" />
                            <Vertex pos="8 -4 -22" />
                            <Vertex pos="8 -4 22" />
                            <Vertex pos="8 4 -22" />
                            <Vertex pos="8 4 22" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -8" album="Blasted" material="bm_grid_blank4" texgens="0 -1 0 -6144 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_tile01_B" texgens="1 0 0 12288 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -22" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6144 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -22" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6144 0 -1 0 -6144 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6144 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -8" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 6144 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="142" owner="0" type="0" pos="-15 -28.25 -25.75" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -28.25 0 0 1 -25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.5 -0.25 -0.25" />
                            <Vertex pos="-9.5 -0.25 0.25" />
                            <Vertex pos="-9.5 0.25 -0.25" />
                            <Vertex pos="-9.5 0.25 0.25" />
                            <Vertex pos="9.5 -0.25 -0.25" />
                            <Vertex pos="9.5 -0.25 0.25" />
                            <Vertex pos="9.5 0.25 -0.25" />
                            <Vertex pos="9.5 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -9.5" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 2432 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 2432 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 2432 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 2432 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -9.5" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="143" owner="0" type="0" pos="-24.25 -18.75 -25.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 -18.75 0 0 1 -25.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -9.25 -0.25" />
                            <Vertex pos="-0.25 -9.25 0.25" />
                            <Vertex pos="-0.25 9.25 -0.25" />
                            <Vertex pos="-0.25 9.25 0.25" />
                            <Vertex pos="0.25 -9.25 -0.25" />
                            <Vertex pos="0.25 -9.25 0.25" />
                            <Vertex pos="0.25 9.25 -0.25" />
                            <Vertex pos="0.25 9.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 2368 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -9.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 2368 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 2368 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -9.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="144" owner="0" type="0" pos="-24.25 -28.25 -29" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 -28.25 0 0 1 -29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 0.25 3" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="145" owner="0" type="0" pos="-5.75 -28.25 -29" rot="1 0 0 0" scale="" transform="1 0 0 -5.75 0 1 0 -28.25 0 0 1 -29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 0.25 3" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="146" owner="0" type="0" pos="-24.25 -9.75 -29" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 -9.75 0 0 1 -29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 0.25 3" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="147" owner="0" type="0" pos="-11 7 -31.5" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 7 0 0 1 -31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -896 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1408 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -2816 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1408 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 896 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="148" owner="0" type="0" pos="-11 13 -31.5" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 13 0 0 1 -31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1664 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1408 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1408 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -2816 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1408 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1664 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="149" owner="0" type="0" pos="-15 -25 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -25 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 3200 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 3200 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3840 0 -1 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -3200 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="150" owner="0" type="0" pos="-17 -23 -31.5" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -23 0 0 1 -31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2944 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2176 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -4352 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2176 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2944 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="151" owner="0" type="0" pos="-15 -21 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -21 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2688 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3840 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2688 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="152" owner="0" type="0" pos="-17 -21 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 -21 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2688 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2176 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2176 0 -1 0 2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -4352 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2176 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2688 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="153" owner="0" type="0" pos="-19 -23 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 -23 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2944 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2432 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -4864 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2432 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2944 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="154" owner="0" type="0" pos="-15 -19 -31.5" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 -19 0 0 1 -31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2432 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1920 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1920 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3840 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1920 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2432 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="155" owner="0" type="0" pos="-19 -17 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 -17 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2176 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2432 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2432 0 -1 0 2176 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -4864 0 -1 0 4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2432 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2176 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="156" owner="0" type="0" pos="-21 -19 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 -19 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2432 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2688 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 2688 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -5376 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2688 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2432 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="157" owner="0" type="0" pos="-13 -19 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 -13 0 1 0 -19 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2432 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1664 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1664 0 -1 0 2432 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3328 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1664 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2432 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="158" owner="0" type="0" pos="11 -15 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -15 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1408 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1408 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2816 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1408 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="159" owner="0" type="0" pos="15 -15 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -15 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3840 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -1920 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="160" owner="0" type="0" pos="13 -19 -29.5" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -19 0 0 1 -29.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2432 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3328 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1664 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2432 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="161" owner="0" type="0" pos="17 -15 -31.5" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -15 0 0 1 -31.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 1920 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2176 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -2176 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4352 0 -1 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2176 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -1920 0 0 -1 4032 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="162" owner="0" type="0" pos="47.75 5 28" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 5 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -1 -2" />
                            <Vertex pos="0.25 -1 2" />
                            <Vertex pos="-0.75 1 0" />
                            <Vertex pos="0.750004 -1 -2" />
                            <Vertex pos="0.750004 -1 2" />
                            <Vertex pos="-0.249992 1 0" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1280 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0 -1 -3584 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -0.707107 -0.707107 -2986.82 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0.707107 -0.707107 -2081.72 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894428 0.447212 -0 -0.223612" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -2160.94 0 0 -1 -3584 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="163" owner="0" type="0" pos="47.75 15 28" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 15 0 0 1 28 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 -1 1.90735e-006" />
                            <Vertex pos="0.25 1 -2" />
                            <Vertex pos="0.25 1 2" />
                            <Vertex pos="-0.250004 -1 0" />
                            <Vertex pos="0.75 1 -2" />
                            <Vertex pos="0.75 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3840 0 0 -1 -7168 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707106 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="2.69742e-006 -0.707107 0.707106 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 -3891.92 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0 -1 -3584 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -0.447215 0 -0.223605" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 4450.67 0 0 -1 -3584 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="164" owner="0" type="0" pos="47.75 10 27" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 10 0 0 1 27 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -6 -1" />
                            <Vertex pos="-0.75 -4 1" />
                            <Vertex pos="0.25 6 -1" />
                            <Vertex pos="-0.75 4 1" />
                            <Vertex pos="0.75 -6 -1" />
                            <Vertex pos="-0.25 -4 1" />
                            <Vertex pos="0.75 6 -1" />
                            <Vertex pos="-0.25 4 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -2560 0 0 -1 -6912 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 -3348.86 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -1 0 -1280 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -3.53553" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0.707107 -0.707107 -1538.66 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0 0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 1280 0.447214 0 -0.894427 -357.768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="165" owner="0" type="0" pos="47.75 -13 6" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -13 0 0 1 6 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 -0.999999 0" />
                            <Vertex pos="0.249996 1 -2" />
                            <Vertex pos="0.249996 1 2" />
                            <Vertex pos="-0.250004 -0.999999 0" />
                            <Vertex pos="0.75 1 -2" />
                            <Vertex pos="0.75 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894428 0.447212 0 -0.223609" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 3328 0 0 -1 -1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -1719.68 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 633.568 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894426 -0.447215 0 -0.223605" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 1245.05 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="166" owner="0" type="0" pos="47.75 -15 7" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -15 0 0 1 7 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.750004 -1 -1" />
                            <Vertex pos="0.249996 -3 1" />
                            <Vertex pos="-0.750004 0.999999 -1" />
                            <Vertex pos="0.249996 3 1" />
                            <Vertex pos="-0.250004 -1 -1" />
                            <Vertex pos="0.75 -3 1" />
                            <Vertex pos="-0.25 1 -1" />
                            <Vertex pos="0.75 3 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 3840 0 0 -1 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0.707107 -0.707107 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -1991.21 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.707107 -0.707107 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -0.707107 -0.707107 724.078 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894428 -1.78595e-006 -0.447212 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1920 -0.447214 0 -0.894427 -3534.78 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="167" owner="0" type="0" pos="47.75 -15 5" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -15 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.250004 -3 -1" />
                            <Vertex pos="-0.749996 -1 1" />
                            <Vertex pos="0.250004 3 -1" />
                            <Vertex pos="-0.749996 0.999999 1" />
                            <Vertex pos="0.75 -3 -1" />
                            <Vertex pos="-0.250004 -1 1" />
                            <Vertex pos="0.749996 3 -1" />
                            <Vertex pos="-0.250004 1 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223603" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 3840 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707106 -0.707107 905.095 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-1.43302e-006 0.707107 0.707107 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0.707107 -0.707107 -1810.19 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 5.95317e-007 0.447214 -0.223604" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1920 0.447214 0 -0.894427 2160.94 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="168" owner="0" type="0" pos="47.75 -13 -2" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -13 0 0 1 -2 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.750004 -1 2.38419e-007" />
                            <Vertex pos="0.249996 1 -2" />
                            <Vertex pos="0.249996 1 2" />
                            <Vertex pos="-0.250004 -1 -2.38419e-007" />
                            <Vertex pos="0.75 1 -2" />
                            <Vertex pos="0.75 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 3328 0 0 -1 512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -995.607 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="6.74351e-007 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 1357.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -0.447215 0 -0.223605" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 1245.05 0 0 -1 256 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="169" owner="0" type="0" pos="47.75 -15 -1" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -15 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.750004 -0.999999 -1" />
                            <Vertex pos="0.249996 -3 1" />
                            <Vertex pos="-0.750004 1 -1" />
                            <Vertex pos="0.249996 3 1" />
                            <Vertex pos="-0.250004 -1 -1" />
                            <Vertex pos="0.75 -3 1" />
                            <Vertex pos="-0.25 0.999999 -1" />
                            <Vertex pos="0.75 3 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 3840 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-1.43299e-006 -0.707107 -0.707106 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -1267.14 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.707107 -0.707107 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -0.707107 -0.707107 1448.15 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894428 -1.78595e-006 -0.447212 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1920 -0.447214 0 -0.894427 -2618.89 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="170" owner="0" type="0" pos="47.75 -15 -3" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -15 0 0 1 -3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.249996 -3 -1" />
                            <Vertex pos="-0.750004 -1 1" />
                            <Vertex pos="0.249996 3 -1" />
                            <Vertex pos="-0.750004 1 1" />
                            <Vertex pos="0.750008 -3 -1" />
                            <Vertex pos="-0.249992 -1 1" />
                            <Vertex pos="0.750004 3 -1" />
                            <Vertex pos="-0.249996 1 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 3840 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707106 -0.707107 1629.17 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -1.41421" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0.707107 -0.707107 -1086.12 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 5.95317e-007 0.447214 -0.223611" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -1920 0.447214 0 -0.894427 3076.83 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="171" owner="0" type="0" pos="-11 43.75 6.00001" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 43.75 0 0 1 6.00001 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -0.25 -2" />
                            <Vertex pos="-1 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.5" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="0.999999 -0.25 -2" />
                            <Vertex pos="0.999999 -0.25 2" />
                            <Vertex pos="1.5 0.25 -2.5" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -0.883883" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 1536 1 0 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 640 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707106 -0.707107 0 -0.883882" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="172" owner="0" type="0" pos="-11 43.75 -1.99999" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 43.75 0 0 1 -1.99999 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -0.25 -2" />
                            <Vertex pos="-1 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.5" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="0.999999 -0.25 -2" />
                            <Vertex pos="0.999999 -0.25 2" />
                            <Vertex pos="1.5 0.25 -2.5" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -0.883883" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 -511.998 1 0 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 640 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707106 -0.707107 0 -0.883882" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="173" owner="0" type="0" pos="-9.00001 43.75 2" rot="1 0 0 0" scale="" transform="1 0 0 -9.00001 0 1 0 43.75 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999999 -0.25 -2" />
                            <Vertex pos="-0.999999 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.5" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="0.999996 -0.25 -1.99999" />
                            <Vertex pos="0.999996 -0.25 2" />
                            <Vertex pos="1.5 0.25 -2.5" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707106 -0.707107 -0 -0.883882" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 512.001 1 0 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 639.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="174" owner="0" type="0" pos="14 43.75 27" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 43.75 0 0 1 27 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -0.25 -1.00001" />
                            <Vertex pos="-4 -0.25 1.00001" />
                            <Vertex pos="-4.5 0.25 -1.50001" />
                            <Vertex pos="-4.5 0.25 1.50001" />
                            <Vertex pos="4 -0.25 -1.00001" />
                            <Vertex pos="4 -0.25 1.00001" />
                            <Vertex pos="4.5 0.25 -1.50001" />
                            <Vertex pos="4.5 0.25 1.50001" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -3.0052" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 6912 1 0 0 3584 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -0.883891" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -0.883891" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 384.003 1 0 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 -0.707107 0 -3.0052" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="175" owner="0" type="0" pos="19 43.75 26" rot="1 0 0 0" scale="" transform="1 0 0 19 0 1 0 43.75 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -0.25 -1.99999" />
                            <Vertex pos="-1 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.49999" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="0.999998 -0.25 -1.99999" />
                            <Vertex pos="0.999998 -0.25 1.99999" />
                            <Vertex pos="1.5 0.25 -2.49999" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -0.883883" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 6656 1 0 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59098" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="3.54029e-006 -0.707116 0.707098 -1.59097" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 639.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707105 -0.707108 0 -0.883881" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="176" owner="0" type="0" pos="9 43.75 26" rot="1 0 0 0" scale="" transform="1 0 0 9 0 1 0 43.75 0 0 1 26 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999998 -0.25 -1.99999" />
                            <Vertex pos="-0.999998 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.49999" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="0.999997 -0.25 -1.99999" />
                            <Vertex pos="0.999997 -0.25 1.99999" />
                            <Vertex pos="1.5 0.25 -2.49999" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707105 -0.707108 -0 -0.883881" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 6656 1 0 0 2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59098" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="3.5403e-006 -0.707116 0.707098 -1.59097" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 639.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707105 -0.707109 0 -0.88388" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="177" owner="0" type="0" pos="41.75 -18.75 40.25" rot="1 0 0 0" scale="" transform="1 0 0 41.75 0 1 0 -18.75 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -9.25 -0.25" />
                            <Vertex pos="-0.25 -9.25 0.25" />
                            <Vertex pos="-0.25 9.25 -0.25" />
                            <Vertex pos="-0.25 9.25 0.25" />
                            <Vertex pos="0.25 -9.25 -0.25" />
                            <Vertex pos="0.25 -9.25 0.25" />
                            <Vertex pos="0.25 9.25 -0.25" />
                            <Vertex pos="0.25 9.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -9.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 2368 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -9.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="178" owner="0" type="0" pos="41.75 -28.25 31" rot="1 0 0 0" scale="" transform="1 0 0 41.75 0 1 0 -28.25 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -9.5" />
                            <Vertex pos="-0.25 -0.25 9.5" />
                            <Vertex pos="-0.25 0.25 -9.5" />
                            <Vertex pos="-0.25 0.25 9.5" />
                            <Vertex pos="0.25 -0.25 -9.5" />
                            <Vertex pos="0.25 -0.25 9.5" />
                            <Vertex pos="0.25 0.25 -9.5" />
                            <Vertex pos="0.25 0.25 9.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 2432 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -9.5" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -9.5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 2432 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="179" owner="0" type="0" pos="45 -28.25 40.25" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 -28.25 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="180" owner="0" type="0" pos="45 -28.25 21.75" rot="1 0 0 0" scale="" transform="1 0 0 45 0 1 0 -28.25 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="181" owner="0" type="0" pos="47.75 -22 37" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -22 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.750004 -2 -1" />
                            <Vertex pos="0.249996 -4 1" />
                            <Vertex pos="-0.750004 2 -1" />
                            <Vertex pos="0.249996 4 1" />
                            <Vertex pos="-0.250004 -2 -1" />
                            <Vertex pos="0.75 -4 0.999996" />
                            <Vertex pos="-0.250004 2 -1" />
                            <Vertex pos="0.749996 4 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 5632 0 0 -1 -9472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0.707106 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -5340.07 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="7.98696e-006 -4.99185e-007 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.707107 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -0.707107 -0.707107 -1357.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0 -0.447214 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 -0.447214 0 -0.894427 -6969.38 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="182" owner="0" type="0" pos="47.75 -24 29" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -24 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.249992 -2 -0.999998" />
                            <Vertex pos="-0.750004 -1.90735e-006 0.999998" />
                            <Vertex pos="0.249992 2 -0.999998" />
                            <Vertex pos="0.750004 -2 -1" />
                            <Vertex pos="-0.249996 0 0.999998" />
                            <Vertex pos="0.75 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894428 0 -0.447213 -0.223612" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 6144 0 0 -1 -7424 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="2.86592e-006 -0.707106 0.707108 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 -452.549 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="-4.05305e-006 -0 -1 -0.999997" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -1 0 3072 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="-2.69736e-006 0.707107 0.707106 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0.707107 -0.707107 -4797.01 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 8.92976e-007 0.447213 -0.223609" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -3072 0.447214 0 -0.894427 -586.741 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="183" owner="0" type="0" pos="47.75 -23 33" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -23 0 0 1 33 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.750004 -1 -3" />
                            <Vertex pos="-0.750004 -1 3" />
                            <Vertex pos="0.249996 1 -5" />
                            <Vertex pos="0.249996 1 5" />
                            <Vertex pos="-0.249992 -1 -3" />
                            <Vertex pos="-0.249992 -1 3" />
                            <Vertex pos="0.750008 1 -5" />
                            <Vertex pos="0.750008 1 5" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 5888 0 0 -1 -8448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0 -1 -4224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -5068.54 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 -905.097 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0 -1 -4224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 -0.447214 0 -0.223614" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 100.179 0 0 -1 -4224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="184" owner="0" type="0" pos="47.75 -22 35" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -22 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -4 -1" />
                            <Vertex pos="-0.75 -2 1" />
                            <Vertex pos="0.25 4 -1" />
                            <Vertex pos="-0.75 2 1" />
                            <Vertex pos="0.749992 -4 -1" />
                            <Vertex pos="-0.250008 -2 1" />
                            <Vertex pos="0.749996 4 -1" />
                            <Vertex pos="-0.250004 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 5632 0 0 -1 -8960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -1 0 2816 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0.707107 -0.707107 -5159.05 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 -4.46488e-007 0.447213 -0.223602" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2816 0.447214 0 -0.894427 -1273.66 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="185" owner="0" type="0" pos="47.75 -25 33" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -25 0 0 1 33 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -1 -5" />
                            <Vertex pos="0.25 -1 5" />
                            <Vertex pos="-0.75 1 -3" />
                            <Vertex pos="-0.75 1 3" />
                            <Vertex pos="0.75 -1 -5" />
                            <Vertex pos="0.75 -1 5" />
                            <Vertex pos="-0.25 1 -3" />
                            <Vertex pos="-0.25 1 3" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 6400 0 0 -1 -8448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0 -1 -4224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -0.707107 -0.707107 -724.077 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -2.82843" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0.707107 -0.707107 -5249.56 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0 -1 -4224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0.447214 -0 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -5595.54 0 0 -1 -4224 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="186" owner="0" type="0" pos="47.75 -19 36" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -19 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.749996 -1 0" />
                            <Vertex pos="0.250004 1 -2" />
                            <Vertex pos="0.250004 1 2" />
                            <Vertex pos="-0.250004 -1 3.8147e-006" />
                            <Vertex pos="0.749996 1 -2" />
                            <Vertex pos="0.749996 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223603" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 4864 0 0 -1 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -4978.03 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="-5.3949e-006 -0.707105 0.707109 -0.707109" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 -1538.66 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -0.447214 0 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 558.125 0 0 -1 -4608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="187" owner="0" type="0" pos="47.75 -18 33" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -18 0 0 1 33 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 1" />
                            <Vertex pos="-0.75 0 -1" />
                            <Vertex pos="0.25 2 1" />
                            <Vertex pos="0.75 -2 1" />
                            <Vertex pos="-0.250004 0 -1" />
                            <Vertex pos="0.75 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 4608 0 0 -1 -8448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -4615.99 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -0.707107 -0.707107 -1357.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 0 -0.447215 -0.223605" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2304 -0.447214 0 -0.894427 -6511.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="188" owner="0" type="0" pos="47.75 -18 31" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -18 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.249996 -2 -1" />
                            <Vertex pos="-0.750004 0 1" />
                            <Vertex pos="0.249996 2 -1" />
                            <Vertex pos="0.75 -2 -1" />
                            <Vertex pos="-0.250004 0 1" />
                            <Vertex pos="0.749996 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 4608 0 0 -1 -7936 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -1 0 2304 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0.707107 -0.707107 -4434.98 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 8.92976e-007 0.447214 -0.223604" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 -2304 0.447214 0 -0.894427 -815.714 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="189" owner="0" type="0" pos="47.75 -19 32" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -19 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.249992 -1 -2" />
                            <Vertex pos="0.249992 -1 2" />
                            <Vertex pos="-0.750004 0.999998 0" />
                            <Vertex pos="0.750004 -1 -2" />
                            <Vertex pos="0.750004 -1 2" />
                            <Vertex pos="-0.249996 0.999998 0" />
                        </Vertices>
                        <Face id="0" plane="-0.894428 -0.447213 -0 -0.223613" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 4864 0 0 -1 -8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0 -1 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707106 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707106 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0.707107 -0.707107 -4615.99 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 0.447214 -0 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -4908.62 0 0 -1 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="190" owner="0" type="0" pos="47.75 -17 32" rot="1 0 0 0" scale="" transform="1 0 0 47.75 0 1 0 -17 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 -1 0" />
                            <Vertex pos="0.25 1 -2" />
                            <Vertex pos="0.25 1 2" />
                            <Vertex pos="-0.249996 -1 0" />
                            <Vertex pos="0.750004 1 -2" />
                            <Vertex pos="0.750004 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 4352 0 0 -1 -8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 0.707107 -0.707107 -4434.98 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6112 0 -0.707107 -0.707107 -1357.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6112 0 0 -1 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -0.447214 0 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 787.099 0 0 -1 -4096 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="191" owner="0" type="0" pos="-11 11 -30.75" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 11 0 0 1 -30.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 0.250004" />
                            <Vertex pos="-1 -1 0.749998" />
                            <Vertex pos="-1 1 -0.749998" />
                            <Vertex pos="-1 1 -0.250002" />
                            <Vertex pos="1 -1 0.250002" />
                            <Vertex pos="1 -1 0.749998" />
                            <Vertex pos="1 1 -0.749998" />
                            <Vertex pos="1 1 -0.250002" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1408 0 0 -1 3936 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1408 0 0 -1 3936 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.447214 -0.894427 -0.223604" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1408 0 1 0 1408 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.447214 0.894427 -0.223605" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -2816 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1408 0 0 -1 3936 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1408 0 0 -1 3936 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="192" owner="0" type="0" pos="-11 9 -30.75" rot="1 0 0 0" scale="" transform="1 0 0 -11 0 1 0 9 0 0 1 -30.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.249998" />
                            <Vertex pos="-1 -1 -0.75" />
                            <Vertex pos="-1 1 0.750002" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.249998" />
                            <Vertex pos="1 -1 -0.75" />
                            <Vertex pos="1 1 0.750002" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1152 0 0 -1 3936 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1408 0 0 -1 3936 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.447214 0.894427 -0.223609" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -2816 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.447214 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1408 0 1 0 1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1408 0 0 -1 3936 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1152 0 0 -1 3936 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="193" owner="0" type="0" pos="-9 7 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 7 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -896 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1152 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -2304 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1152 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 896 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="194" owner="0" type="0" pos="-9 13 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 -9 0 1 0 13 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1664 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1152 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 -1664 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -2304 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1152 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1664 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="195" owner="0" type="0" pos="-21 43.75 35" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 43.75 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999996 -0.25 -0.999996" />
                            <Vertex pos="-0.999996 -0.25 0.999992" />
                            <Vertex pos="-1.5 0.25 -1.5" />
                            <Vertex pos="-1.5 0.25 1.49999" />
                            <Vertex pos="0.999996 -0.25 -0.999992" />
                            <Vertex pos="0.999996 -0.25 0.999992" />
                            <Vertex pos="1.5 0.25 -1.5" />
                            <Vertex pos="1.5 0.25 1.49999" />
                        </Vertices>
                        <Face id="0" plane="-0.707104 -0.70711 -0 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 8960 1 0 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.70711 -0.707104 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707105 0.707108 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.998 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="196" owner="0" type="0" pos="-19 43.75 36" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 43.75 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999996 -0.25 -2" />
                            <Vertex pos="-0.999996 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.5" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="0.999992 -0.25 -1.99999" />
                            <Vertex pos="0.999992 -0.25 2" />
                            <Vertex pos="1.5 0.25 -2.5" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707104 -0.70711 -0 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 9216 1 0 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 639.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707101 -0.707112 0 -0.883874" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="197" owner="0" type="0" pos="-17 43.75 34" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 43.75 0 0 1 34 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999998 -0.25 -2" />
                            <Vertex pos="-0.999998 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.5" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="0.999996 -0.25 -2" />
                            <Vertex pos="0.999996 -0.25 2" />
                            <Vertex pos="1.5 0.25 -2.5" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707105 -0.707108 -0 -0.883881" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 8704 1 0 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 639.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707104 -0.70711 0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="198" owner="0" type="0" pos="-19 43.75 31" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 43.75 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999996 -0.25 -0.999994" />
                            <Vertex pos="-0.999996 -0.25 0.999996" />
                            <Vertex pos="-1.5 0.25 -1.5" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="0.999992 -0.25 -0.99999" />
                            <Vertex pos="0.999992 -0.25 0.999996" />
                            <Vertex pos="1.5 0.25 -1.5" />
                            <Vertex pos="1.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707104 -0.70711 -0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 7936 1 0 0 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707111 -0.707103 -0.883876" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.70711 0.707104 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707101 -0.707112 0 -0.883874" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="199" owner="0" type="0" pos="-16 43.75 29" rot="1 0 0 0" scale="" transform="1 0 0 -16 0 1 0 43.75 0 0 1 29 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -0.25 -0.999996" />
                            <Vertex pos="-2 -0.25 0.999996" />
                            <Vertex pos="-2.5 0.25 -1.5" />
                            <Vertex pos="-2.5 0.25 1.5" />
                            <Vertex pos="1.99999 -0.25 -0.999992" />
                            <Vertex pos="1.99999 -0.25 0.999994" />
                            <Vertex pos="2.5 0.25 -1.5" />
                            <Vertex pos="2.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 7424 1 0 0 -4096 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.70711 -0.707104 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="3.58247e-007 -0.707111 0.707102 -0.883877" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.7071 -0.707114 0 -1.59097" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="200" owner="0" type="0" pos="-15 43.75 37" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 43.75 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999998 -0.25 -0.999992" />
                            <Vertex pos="-0.999998 -0.25 0.999996" />
                            <Vertex pos="-1.5 0.25 -1.49999" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="0.999995 -0.25 -0.999992" />
                            <Vertex pos="0.999995 -0.25 0.999996" />
                            <Vertex pos="1.5 0.25 -1.49999" />
                            <Vertex pos="1.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707105 -0.707108 -0 -0.883881" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 9472 1 0 0 -3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707105 -0.707108 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.70711 0.707104 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707103 -0.70711 0 -0.883877" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="201" owner="0" type="0" pos="-14.75 37.75 40.25" rot="1 0 0 0" scale="" transform="1 0 0 -14.75 0 1 0 37.75 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-9.25 -0.25 -0.25" />
                            <Vertex pos="-9.25 -0.25 0.25" />
                            <Vertex pos="-9.25 0.25 -0.25" />
                            <Vertex pos="-9.25 0.25 0.25" />
                            <Vertex pos="9.25 -0.25 -0.25" />
                            <Vertex pos="9.25 -0.25 0.25" />
                            <Vertex pos="9.25 0.25 -0.25" />
                            <Vertex pos="9.25 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -9.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 2368 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 2368 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 2368 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -9.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="202" owner="0" type="0" pos="-24.25 37.75 31" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 37.75 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -9.5" />
                            <Vertex pos="-0.25 -0.25 9.5" />
                            <Vertex pos="-0.25 0.25 -9.5" />
                            <Vertex pos="-0.25 0.25 9.5" />
                            <Vertex pos="0.25 -0.25 -9.5" />
                            <Vertex pos="0.25 -0.25 9.5" />
                            <Vertex pos="0.25 0.25 -9.5" />
                            <Vertex pos="0.25 0.25 9.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 2432 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -9.5" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -9.5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 2432 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 2432 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="203" owner="0" type="0" pos="-24.25 41 40.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 41 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 3 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="204" owner="0" type="0" pos="-5.75 41 40.25" rot="1 0 0 0" scale="" transform="1 0 0 -5.75 0 1 0 41 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 3 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="205" owner="0" type="0" pos="-24.25 41 21.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 41 0 0 1 21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 3 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="206" owner="0" type="0" pos="-24.25 0 -31.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 0 0 0 1 -31.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -4 -0.75" />
                            <Vertex pos="-0.25 -4 -1.25" />
                            <Vertex pos="-0.25 4 1.25" />
                            <Vertex pos="-0.25 4 0.75" />
                            <Vertex pos="0.25 -4 -0.75" />
                            <Vertex pos="0.25 -4 -1.25" />
                            <Vertex pos="0.25 4 1.25" />
                            <Vertex pos="0.25 4 0.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.25 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="0 0 1 320 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.242536 0.970143 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.242536 -0.970143 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1024 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -4" album="Blasted" material="bm_edge_white" texgens="0 0 -1 320 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="207" owner="0" type="0" pos="-24.25 10 -30.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 10 0 0 1 -30.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 6 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1536 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1536 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1536 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="208" owner="0" type="0" pos="-24.25 20 -29.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 20 0 0 1 -29.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -4 -0.750002" />
                            <Vertex pos="-0.25 -4 -1.25" />
                            <Vertex pos="-0.25 4 1.25" />
                            <Vertex pos="-0.25 4 0.75" />
                            <Vertex pos="0.25 -4 -0.750002" />
                            <Vertex pos="0.25 -4 -1.25" />
                            <Vertex pos="0.25 4 1.25" />
                            <Vertex pos="0.25 4 0.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 -0.25 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="0 0 1 320 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -0.242536 0.970142 -0.242535" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.242536 -0.970143 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1024 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -4" album="Blasted" material="bm_edge_white" texgens="0 0 -1 320 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="209" owner="0" type="0" pos="-24.25 30 -28.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 30 0 0 1 -28.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 6 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1536 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1536 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1536 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="210" owner="0" type="0" pos="-24.25 43.25 12" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 43.25 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -1.25 -4" />
                            <Vertex pos="-0.25 0.749996 4" />
                            <Vertex pos="-0.25 -0.75 -4" />
                            <Vertex pos="-0.25 1.25 4" />
                            <Vertex pos="0.25 -1.25 -4" />
                            <Vertex pos="0.25 0.749996 4" />
                            <Vertex pos="0.25 -0.75 -4" />
                            <Vertex pos="0.25 1.25 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 -0.25 64.001 0 0 1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.970143 0.242535 -0.242538" album="Blasted" material="bm_edge_white" texgens="0 0 1 1024 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -192 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 -191.999 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.970143 -0.242536 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1024 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 320.001 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="211" owner="0" type="0" pos="-24.25 42.25 2" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 42.25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -6" />
                            <Vertex pos="-0.25 -0.25 6" />
                            <Vertex pos="-0.25 0.25 -6" />
                            <Vertex pos="-0.25 0.25 6" />
                            <Vertex pos="0.25 -0.25 -6" />
                            <Vertex pos="0.25 -0.25 6" />
                            <Vertex pos="0.25 0.25 -6" />
                            <Vertex pos="0.25 0.25 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 1536 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1536 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="212" owner="0" type="0" pos="-24.25 41.25 -8" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 41.25 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -1.24999 -4" />
                            <Vertex pos="-0.25 0.750008 4" />
                            <Vertex pos="-0.25 -0.75 -4" />
                            <Vertex pos="-0.25 1.25 4" />
                            <Vertex pos="0.25 -1.24999 -4" />
                            <Vertex pos="0.25 0.750008 4" />
                            <Vertex pos="0.25 -0.750004 -4" />
                            <Vertex pos="0.25 1.25 4" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 -0.25 63.998 0 0 1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.970143 0.242535 -0.242527" album="Blasted" material="bm_edge_white" texgens="0 0 1 1024 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -192 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 -192.002 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.970143 -0.242536 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1024 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 319.998 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="213" owner="0" type="0" pos="-24.25 40.25 -18" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 40.25 0 0 1 -18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -6" />
                            <Vertex pos="-0.25 -0.25 6" />
                            <Vertex pos="-0.25 0.25 -6" />
                            <Vertex pos="-0.25 0.25 6" />
                            <Vertex pos="0.25 -0.25 -6" />
                            <Vertex pos="0.25 -0.25 6" />
                            <Vertex pos="0.25 0.25 -6" />
                            <Vertex pos="0.25 0.25 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 1536 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1536 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="214" owner="0" type="0" pos="-24.25 37 -27.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 37 0 0 1 -27.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -1 -0.749998" />
                            <Vertex pos="-0.25 -1 -1.25" />
                            <Vertex pos="-0.25 1 1.25" />
                            <Vertex pos="-0.25 1 0.749998" />
                            <Vertex pos="0.25 -1 -0.749996" />
                            <Vertex pos="0.25 -1 -1.25" />
                            <Vertex pos="0.25 1 1.25" />
                            <Vertex pos="0.25 1 0.749998" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 256 0 -1 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="0 0 1 320.001 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-2.78169e-006 -0.707106 0.707107 -0.176778" album="Blasted" material="bm_edge_white" texgens="0 1 0 256 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707106 -0.707107 -0.176777" album="Blasted" material="bm_edge_white" texgens="0 -1 0 256 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -1" album="Blasted" material="bm_edge_white" texgens="0 0 -1 320.001 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="215" owner="0" type="0" pos="-24.25 39.25 -25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 39.25 0 0 1 -25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -1.25 -1" />
                            <Vertex pos="-0.25 0.749996 1" />
                            <Vertex pos="-0.25 -0.75 -1" />
                            <Vertex pos="-0.25 1.25 1" />
                            <Vertex pos="0.25 -1.25 -1" />
                            <Vertex pos="0.25 0.749996 1" />
                            <Vertex pos="0.25 -0.75 -1" />
                            <Vertex pos="0.25 1.25 1" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 -1 64.001 0 0 1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707106 -0.176778" album="Blasted" material="bm_edge_white" texgens="0 0 1 256 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 -192 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 -191.999 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.707107 -0.707107 -0.176777" album="Blasted" material="bm_edge_white" texgens="0 0 -1 256 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 320.001 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="216" owner="0" type="0" pos="-24.25 38.25 -31" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 38.25 0 0 1 -31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -4.5" />
                            <Vertex pos="-0.25 0.25 -4.5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="0.25 -0.25 -5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 0.25 5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0 -0.707107 -3.35876" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 1280 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -5" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1280 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="217" owner="0" type="0" pos="-24.25 43.25 -26.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 43.25 0 0 1 -26.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 4.25 -0.25" />
                            <Vertex pos="-0.25 4.25 0.25" />
                            <Vertex pos="-0.25 -4.75 -0.25" />
                            <Vertex pos="-0.25 -4.75 0.25" />
                            <Vertex pos="0.25 4.75 -0.25" />
                            <Vertex pos="0.25 4.75 0.25" />
                            <Vertex pos="0.25 -4.75 -0.25" />
                            <Vertex pos="0.25 -4.75 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1216 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="-0.707107 0.707107 0 -3.18198" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -4.75" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="3" plane="0 -0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1216 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="4" plane="0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1216 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="5" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="218" owner="0" type="0" pos="4 -28.25 -31.25" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 -28.25 0 0 1 -31.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -0.25 -0.75" />
                            <Vertex pos="-4 0.25 -0.75" />
                            <Vertex pos="-4 -0.25 -1.25" />
                            <Vertex pos="-4 0.25 -1.25" />
                            <Vertex pos="4 -0.25 1.25" />
                            <Vertex pos="4 0.25 1.25" />
                            <Vertex pos="4 -0.25 0.75" />
                            <Vertex pos="4 0.25 0.75" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -4" album="Blasted" material="bm_edge_white" texgens="0 0 1 320 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.242536 0 0.970143 -0.242536" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 -0.25 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 -0.970143 -0.242536" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1024 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 0 -1 320 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="219" owner="0" type="0" pos="14 -28.25 -30.25" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 -28.25 0 0 1 -30.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="220" owner="0" type="0" pos="24 -28.25 -29.25" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 -28.25 0 0 1 -29.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 -0.25 -0.750002" />
                            <Vertex pos="-4 0.25 -0.750002" />
                            <Vertex pos="-4 -0.25 -1.25" />
                            <Vertex pos="-4 0.25 -1.25" />
                            <Vertex pos="4 -0.25 1.25" />
                            <Vertex pos="4 0.25 1.25" />
                            <Vertex pos="4 -0.25 0.750002" />
                            <Vertex pos="4 0.25 0.750002" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -4" album="Blasted" material="bm_edge_white" texgens="0 0 1 320 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.242536 0 0.970142 -0.242535" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 -0.25 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.242536 0 -0.970142 -0.242535" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1024 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 0 -1 320 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="221" owner="0" type="0" pos="34 -28.25 -28.25" rot="1 0 0 0" scale="" transform="1 0 0 34 0 1 0 -28.25 0 0 1 -28.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="222" owner="0" type="0" pos="41 -28.25 -27.25" rot="1 0 0 0" scale="" transform="1 0 0 41 0 1 0 -28.25 0 0 1 -27.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -0.25 -0.749998" />
                            <Vertex pos="-1 0.249998 -0.749998" />
                            <Vertex pos="-1 -0.25 -1.25" />
                            <Vertex pos="-1 0.249998 -1.25" />
                            <Vertex pos="1 -0.25 1.25" />
                            <Vertex pos="1 0.25 1.25" />
                            <Vertex pos="1 -0.25 0.75" />
                            <Vertex pos="1 0.25 0.75" />
                        </Vertices>
                        <Face id="0" plane="-1 -0 -0 -1" album="Blasted" material="bm_edge_white" texgens="0 0 1 320 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707106 0 0.707107 -0.176777" album="Blasted" material="bm_edge_white" texgens="1 0 0 256 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 256 -1 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-9.98378e-007 1 0 -0.249999" album="Blasted" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0 -0.707107 -0.176777" album="Blasted" material="bm_edge_white" texgens="-1 0 0 256 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 0 -1 320 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="223" owner="0" type="0" pos="43.25 -28.25 -25" rot="1 0 0 0" scale="" transform="1 0 0 43.25 0 1 0 -28.25 0 0 1 -25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.25 -0.25 -1" />
                            <Vertex pos="0.75 -0.25 1" />
                            <Vertex pos="-1.25 0.25 -1" />
                            <Vertex pos="0.75 0.25 1" />
                            <Vertex pos="-0.75 -0.25 -1" />
                            <Vertex pos="1.25 -0.25 1" />
                            <Vertex pos="-0.75 0.249998 -1" />
                            <Vertex pos="1.25 0.249998 1" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 0 0.707107 -0.176777" album="Blasted" material="bm_edge_white" texgens="0 0 1 256 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 -1 64 0 0 1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -192 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -192 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="3.99351e-006 1 -3.99351e-006 -0.249999" album="Blasted" material="bm_edge_white" texgens="1 0 0 320 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0 -0.707107 -0.176777" album="Blasted" material="bm_edge_white" texgens="0 0 -1 256 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="224" owner="0" type="0" pos="42.25 -28.25 -31" rot="1 0 0 0" scale="" transform="1 0 0 42.25 0 1 0 -28.25 0 0 1 -31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -4.5" />
                            <Vertex pos="-0.25 -0.25 5" />
                            <Vertex pos="-0.25 0.249998 -4.99999" />
                            <Vertex pos="-0.25 0.25 5" />
                            <Vertex pos="0.25 -0.25 -4.5" />
                            <Vertex pos="0.25 -0.25 5" />
                            <Vertex pos="0.25 0.25 -5" />
                            <Vertex pos="0.25 0.25 5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 1280 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="-1.13376e-005 -0.707101 -0.707112 -3.35878" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 1 -1.99676e-007 -0.249999" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1280 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="225" owner="0" type="0" pos="47.25 -28.25 -26.25" rot="1 0 0 0" scale="" transform="1 0 0 47.25 0 1 0 -28.25 0 0 1 -26.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4.75 -0.25 -0.25" />
                            <Vertex pos="-4.75 -0.25 0.25" />
                            <Vertex pos="-4.75 0.25 -0.25" />
                            <Vertex pos="-4.75 0.25 0.25" />
                            <Vertex pos="4.25 -0.25 -0.25" />
                            <Vertex pos="4.25 -0.25 0.25" />
                            <Vertex pos="4.75 0.249998 -0.25" />
                            <Vertex pos="4.75 0.249998 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4.75" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1216 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1216 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1216 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="2.10185e-007 1 0 -0.249999" album="Blasted" material="bm_edge_white" texgens="1 0 0 1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707105 -0.707108 0 -3.18197" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="226" owner="0" type="0" pos="44.25 -28.25 -18" rot="1 0 0 0" scale="" transform="1 0 0 44.25 0 1 0 -28.25 0 0 1 -18 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -6" />
                            <Vertex pos="-0.25 -0.25 6" />
                            <Vertex pos="-0.25 0.25 -6" />
                            <Vertex pos="-0.25 0.25 6" />
                            <Vertex pos="0.25 -0.25 -6" />
                            <Vertex pos="0.25 -0.25 6" />
                            <Vertex pos="0.25 0.25 -6" />
                            <Vertex pos="0.25 0.25 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="227" owner="0" type="0" pos="45.25 -28.25 -8" rot="1 0 0 0" scale="" transform="1 0 0 45.25 0 1 0 -28.25 0 0 1 -8 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.25 -0.25 -4" />
                            <Vertex pos="0.75 -0.25 4" />
                            <Vertex pos="-1.25 0.25 -4" />
                            <Vertex pos="0.75 0.25 4" />
                            <Vertex pos="-0.75 -0.25 -4" />
                            <Vertex pos="1.25 -0.25 4" />
                            <Vertex pos="-0.75 0.25 -4" />
                            <Vertex pos="1.25 0.25 4" />
                        </Vertices>
                        <Face id="0" plane="-0.970143 0 0.242536 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 0 1 1024 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 -0.25 64 0 0 1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -192 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -192 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 320 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.970143 0 -0.242536 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1024 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="228" owner="0" type="0" pos="46.25 -28.25 2" rot="1 0 0 0" scale="" transform="1 0 0 46.25 0 1 0 -28.25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -6" />
                            <Vertex pos="-0.25 -0.25 6" />
                            <Vertex pos="-0.25 0.25 -6" />
                            <Vertex pos="-0.25 0.25 6" />
                            <Vertex pos="0.25 -0.25 -6" />
                            <Vertex pos="0.25 -0.25 6" />
                            <Vertex pos="0.25 0.25 -6" />
                            <Vertex pos="0.25 0.25 6" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="229" owner="0" type="0" pos="47.25 -28.25 12" rot="1 0 0 0" scale="" transform="1 0 0 47.25 0 1 0 -28.25 0 0 1 12 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1.25 -0.25 -4" />
                            <Vertex pos="0.75 -0.25 4" />
                            <Vertex pos="-1.25 0.25 -4" />
                            <Vertex pos="0.75 0.25 4" />
                            <Vertex pos="-0.75 -0.25 -4" />
                            <Vertex pos="1.25 -0.25 4" />
                            <Vertex pos="-0.75 0.25 -4" />
                            <Vertex pos="1.25 0.25 4" />
                        </Vertices>
                        <Face id="0" plane="-0.970143 0 0.242536 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 0 1 1024 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 -0.25 64 0 0 1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -192 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -192 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 320 0 0 -1 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.970143 0 -0.242536 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 0 -1 1024 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="230" owner="0" type="0" pos="34.75 -28.25 -21.75" rot="1 0 0 0" scale="" transform="1 0 0 34.75 0 1 0 -28.25 0 0 1 -21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.25 -0.25 -0.25" />
                            <Vertex pos="-3.25 -0.25 0.25" />
                            <Vertex pos="-3.25 0.25 -0.25" />
                            <Vertex pos="-3.25 0.25 0.25" />
                            <Vertex pos="3.25 -0.25 -0.25" />
                            <Vertex pos="3.25 -0.25 0.25" />
                            <Vertex pos="3.25 0.25 -0.25" />
                            <Vertex pos="3.25 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 832 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 832 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 832 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="231" owner="0" type="0" pos="31.75 -28.25 -25" rot="1 0 0 0" scale="" transform="1 0 0 31.75 0 1 0 -28.25 0 0 1 -25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 0.25 3" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="232" owner="0" type="0" pos="37.75 -28.25 -18.75" rot="1 0 0 0" scale="" transform="1 0 0 37.75 0 1 0 -28.25 0 0 1 -18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -2.75" />
                            <Vertex pos="-0.25 -0.25 2.75" />
                            <Vertex pos="-0.25 0.25 -2.75" />
                            <Vertex pos="-0.25 0.25 2.75" />
                            <Vertex pos="0.25 -0.25 -2.75" />
                            <Vertex pos="0.25 -0.25 2.75" />
                            <Vertex pos="0.25 0.25 -2.75" />
                            <Vertex pos="0.25 0.25 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 704 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -2.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 704 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="233" owner="0" type="0" pos="40.75 -28.25 -15.75" rot="1 0 0 0" scale="" transform="1 0 0 40.75 0 1 0 -28.25 0 0 1 -15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.25 -0.25 -0.25" />
                            <Vertex pos="-3.25 -0.25 0.25" />
                            <Vertex pos="-3.25 0.25 -0.25" />
                            <Vertex pos="-3.25 0.25 0.25" />
                            <Vertex pos="3.25 -0.25 -0.25" />
                            <Vertex pos="3.25 -0.25 0.25" />
                            <Vertex pos="3.25 0.25 -0.25" />
                            <Vertex pos="3.25 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 832 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 832 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 832 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="234" owner="0" type="0" pos="-24.25 30.75 -21.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 30.75 0 0 1 -21.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 3.25 -0.25" />
                            <Vertex pos="-0.25 3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 3.25 -0.25" />
                            <Vertex pos="0.25 3.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 832 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 832 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 832 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="235" owner="0" type="0" pos="-24.25 27.75 -25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 27.75 0 0 1 -25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -3" />
                            <Vertex pos="-0.25 -0.25 3" />
                            <Vertex pos="-0.25 0.25 -3" />
                            <Vertex pos="-0.25 0.25 3" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="0.25 -0.25 3" />
                            <Vertex pos="0.25 0.25 -3" />
                            <Vertex pos="0.25 0.25 3" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="236" owner="0" type="0" pos="-24.25 33.75 -18.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 33.75 0 0 1 -18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -2.75" />
                            <Vertex pos="-0.25 -0.25 2.75" />
                            <Vertex pos="-0.25 0.25 -2.75" />
                            <Vertex pos="-0.25 0.25 2.75" />
                            <Vertex pos="0.25 -0.25 -2.75" />
                            <Vertex pos="0.25 -0.25 2.75" />
                            <Vertex pos="0.25 0.25 -2.75" />
                            <Vertex pos="0.25 0.25 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 704 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -2.75" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 704 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 704 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="237" owner="0" type="0" pos="-24.25 36.75 -15.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 36.75 0 0 1 -15.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -3.25 -0.25" />
                            <Vertex pos="-0.25 -3.25 0.25" />
                            <Vertex pos="-0.25 3.25 -0.25" />
                            <Vertex pos="-0.25 3.25 0.25" />
                            <Vertex pos="0.25 -3.25 -0.25" />
                            <Vertex pos="0.25 -3.25 0.25" />
                            <Vertex pos="0.25 3.25 -0.25" />
                            <Vertex pos="0.25 3.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 832 0 0 1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 832 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 832 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 1 0 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="238" owner="0" type="0" pos="4 43.25 40.25" rot="1 0 0 0" scale="" transform="1 0 0 4 0 1 0 43.25 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0.750004 -0.25" />
                            <Vertex pos="-4 0.750004 0.25" />
                            <Vertex pos="-4 1.25 -0.25" />
                            <Vertex pos="-4 1.25 0.25" />
                            <Vertex pos="4 -1.25 -0.25" />
                            <Vertex pos="4 -1.25 0.25" />
                            <Vertex pos="4 -0.749996 -0.25" />
                            <Vertex pos="4 -0.749996 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.242536 -0.970142 0 -0.242534" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 0 1 0 319.999 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 -0.25 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.242535 0.970143 0 -0.242538" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 319.999 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="239" owner="0" type="0" pos="14 42.25 40.25" rot="1 0 0 0" scale="" transform="1 0 0 14 0 1 0 42.25 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="240" owner="0" type="0" pos="24 41.25 40.25" rot="1 0 0 0" scale="" transform="1 0 0 24 0 1 0 41.25 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4 0.750004 -0.25" />
                            <Vertex pos="-4 0.750004 0.25" />
                            <Vertex pos="-4 1.25 -0.25" />
                            <Vertex pos="-4 1.25 0.25" />
                            <Vertex pos="4 -1.25 -0.25" />
                            <Vertex pos="4 -1.25 0.25" />
                            <Vertex pos="4 -0.749996 -0.25" />
                            <Vertex pos="4 -0.749996 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4" album="Blasted" material="bm_edge_white" texgens="0 -1 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.242536 -0.970142 0 -0.242534" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 0 1 0 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1024 -0.25 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.242535 0.970143 0 -0.242538" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -4" album="Blasted" material="bm_edge_white" texgens="0 1 0 319.999 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="241" owner="0" type="0" pos="34 40.25 40.25" rot="1 0 0 0" scale="" transform="1 0 0 34 0 1 0 40.25 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -0.25 -0.25" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 0.25 -0.25" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="6 -0.25 -0.25" />
                            <Vertex pos="6 -0.25 0.25" />
                            <Vertex pos="6 0.25 -0.25" />
                            <Vertex pos="6 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -6" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="242" owner="0" type="0" pos="47.25 0 40.25" rot="1 0 0 0" scale="" transform="1 0 0 47.25 0 1 0 0 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 -4 -0.25" />
                            <Vertex pos="0.75 -4 0.25" />
                            <Vertex pos="-1.25 4 -0.25" />
                            <Vertex pos="-1.25 4 0.25" />
                            <Vertex pos="1.25 -4 -0.25" />
                            <Vertex pos="1.25 -4 0.25" />
                            <Vertex pos="-0.75 4 -0.25" />
                            <Vertex pos="-0.75 4 0.25" />
                        </Vertices>
                        <Face id="0" plane="-0.970143 -0.242536 -0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 320 0 1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0.25 0 64 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.970143 0.242536 -0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="243" owner="0" type="0" pos="46.25 10 40.25" rot="1 0 0 0" scale="" transform="1 0 0 46.25 0 1 0 10 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 6 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="244" owner="0" type="0" pos="45.25 20 40.25" rot="1 0 0 0" scale="" transform="1 0 0 45.25 0 1 0 20 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.750004 -4 -0.25" />
                            <Vertex pos="0.750004 -4 0.25" />
                            <Vertex pos="-1.25 4 -0.25" />
                            <Vertex pos="-1.25 4 0.25" />
                            <Vertex pos="1.25 -4 -0.25" />
                            <Vertex pos="1.25 -4 0.25" />
                            <Vertex pos="-0.75 4 -0.25" />
                            <Vertex pos="-0.75 4 0.25" />
                        </Vertices>
                        <Face id="0" plane="-0.970142 -0.242536 -0 -0.242534" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -4" album="Blasted" material="bm_edge_white" texgens="1 0 0 -192.001 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 319.999 0 1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0.25 0 63.999 0 -1 0 1024 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -4" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.970143 0.242536 -0 -0.242536" album="Blasted" material="bm_edge_white" texgens="0 1 0 1024 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="245" owner="0" type="0" pos="44.25 30 40.25" rot="1 0 0 0" scale="" transform="1 0 0 44.25 0 1 0 30 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -6 -0.25" />
                            <Vertex pos="-0.25 -6 0.25" />
                            <Vertex pos="-0.25 6 -0.25" />
                            <Vertex pos="-0.25 6 0.25" />
                            <Vertex pos="0.25 -6 -0.25" />
                            <Vertex pos="0.25 -6 0.25" />
                            <Vertex pos="0.25 6 -0.25" />
                            <Vertex pos="0.25 6 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -6" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -6" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1536 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="246" owner="0" type="0" pos="43.25 37 40.25" rot="1 0 0 0" scale="" transform="1 0 0 43.25 0 1 0 37 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.75 -1 -0.25" />
                            <Vertex pos="0.75 -1 0.25" />
                            <Vertex pos="-1.25 1 -0.25" />
                            <Vertex pos="-1.25 1 0.25" />
                            <Vertex pos="1.25 -1 -0.25" />
                            <Vertex pos="1.25 -1 0.25" />
                            <Vertex pos="-0.75 1 -0.25" />
                            <Vertex pos="-0.75 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -0.176777" album="Blasted" material="bm_edge_white" texgens="0 -1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 320 0 1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 1 0 64 0 -1 0 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_edge_white" texgens="-1 0 0 -192 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0.707107 -0 -0.176777" album="Blasted" material="bm_edge_white" texgens="0 1 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="247" owner="0" type="0" pos="41 39.25 40.25" rot="1 0 0 0" scale="" transform="1 0 0 41 0 1 0 39.25 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 0.75 -0.25" />
                            <Vertex pos="-1 0.75 0.25" />
                            <Vertex pos="-1 1.25 -0.25" />
                            <Vertex pos="-1 1.25 0.25" />
                            <Vertex pos="1 -1.25 -0.25" />
                            <Vertex pos="1 -1.25 0.25" />
                            <Vertex pos="1 -0.75 -0.25" />
                            <Vertex pos="1 -0.75 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_edge_white" texgens="0 -1 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0.707107 -0.707107 0 -0.176777" album="Blasted" material="bm_edge_white" texgens="1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 256 0 1 0 320 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 256 -1 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0.707107 0 -0.176777" album="Blasted" material="bm_edge_white" texgens="-1 0 0 256 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_edge_white" texgens="0 1 0 320 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="248" owner="0" type="0" pos="42.25 43 40.25" rot="1 0 0 0" scale="" transform="1 0 0 42.25 0 1 0 43 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -5 -0.25" />
                            <Vertex pos="-0.25 -5 0.25" />
                            <Vertex pos="-0.25 5 -0.25" />
                            <Vertex pos="-0.25 4.5 0.25" />
                            <Vertex pos="0.25 -5 -0.25" />
                            <Vertex pos="0.25 -5 0.25" />
                            <Vertex pos="0.25 5 -0.25" />
                            <Vertex pos="0.25 4.5 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -5" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 1152 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -3.35876" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 1280 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="249" owner="0" type="0" pos="47.25 38.25 40.25" rot="1 0 0 0" scale="" transform="1 0 0 47.25 0 1 0 38.25 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-4.75 -0.25 -0.25" />
                            <Vertex pos="-4.75 -0.25 0.25" />
                            <Vertex pos="-4.75 0.25 -0.25" />
                            <Vertex pos="-4.75 0.25 0.25" />
                            <Vertex pos="4.75 -0.25 -0.25" />
                            <Vertex pos="4.25 -0.25 0.25" />
                            <Vertex pos="4.75 0.25 -0.25" />
                            <Vertex pos="4.25 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -4.75" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1216 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1216 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1216 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 0 0.707107 -3.18198" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="250" owner="0" type="0" pos="37.75 30.5 40.25" rot="1 0 0 0" scale="" transform="1 0 0 37.75 0 1 0 30.5 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 3 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="251" owner="0" type="0" pos="41 27.75 40.25" rot="1 0 0 0" scale="" transform="1 0 0 41 0 1 0 27.75 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3 -0.25 -0.25" />
                            <Vertex pos="-3 -0.25 0.25" />
                            <Vertex pos="-3 0.25 -0.25" />
                            <Vertex pos="-3 0.25 0.25" />
                            <Vertex pos="3 -0.25 -0.25" />
                            <Vertex pos="3 -0.25 0.25" />
                            <Vertex pos="3 0.25 -0.25" />
                            <Vertex pos="3 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -3" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 768 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -3" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="252" owner="0" type="0" pos="34.75 33.75 40.25" rot="1 0 0 0" scale="" transform="1 0 0 34.75 0 1 0 33.75 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-3.25 -0.25 -0.25" />
                            <Vertex pos="-3.25 -0.25 0.25" />
                            <Vertex pos="-3.25 0.25 -0.25" />
                            <Vertex pos="-3.25 0.25 0.25" />
                            <Vertex pos="3.25 -0.25 -0.25" />
                            <Vertex pos="3.25 -0.25 0.25" />
                            <Vertex pos="3.25 0.25 -0.25" />
                            <Vertex pos="3.25 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 832 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 832 0 -1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="-1 0 0 832 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -3.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="253" owner="0" type="0" pos="31.75 37 40.25" rot="1 0 0 0" scale="" transform="1 0 0 31.75 0 1 0 37 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -3 -0.25" />
                            <Vertex pos="-0.25 -3 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="0.25 -3 -0.25" />
                            <Vertex pos="0.25 -3 0.25" />
                            <Vertex pos="0.25 3 -0.25" />
                            <Vertex pos="0.25 3 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -3" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 -1 0 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -3" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="254" owner="0" type="0" pos="-17 7 -29.75" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 7 0 0 1 -29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -896 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2176 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -4352 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2176 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 896 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="255" owner="0" type="0" pos="-19 9 -29.75" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 9 0 0 1 -29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1152 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2432 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -4864 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2432 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1152 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="256" owner="0" type="0" pos="-17 9 -29.5" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 9 0 0 1 -29.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1152 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2176 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -4352 0 -1 0 -2304 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2176 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1152 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="257" owner="0" type="0" pos="-17 11 -29.75" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 11 0 0 1 -29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1408 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2176 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -4352 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2176 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1408 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="258" owner="0" type="0" pos="-19 13 -29.5" rot="1 0 0 0" scale="" transform="1 0 0 -19 0 1 0 13 0 0 1 -29.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1664 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2432 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -4864 0 -1 0 -3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2432 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1664 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="259" owner="0" type="0" pos="-21 11 -29.75" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 11 0 0 1 -29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1408 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -2688 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -5376 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 2688 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1408 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="260" owner="0" type="0" pos="-15 11 -29.75" rot="1 0 0 0" scale="" transform="1 0 0 -15 0 1 0 11 0 0 1 -29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -1408 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 -1920 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 1152 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 -3840 0 -1 0 -2816 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 1920 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 1408 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="261" owner="0" type="0" pos="15 -23 -29.75" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 -23 0 0 1 -29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2944 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1920 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3840 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1920 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2944 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="262" owner="0" type="0" pos="11 -25 -29.75" rot="1 0 0 0" scale="" transform="1 0 0 11 0 1 0 -25 0 0 1 -29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 3200 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1408 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 2816 0 -1 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1408 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -3200 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="263" owner="0" type="0" pos="17 -21 -29.5" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -21 0 0 1 -29.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2688 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2176 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4352 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2176 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2688 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="264" owner="0" type="0" pos="17 -25 -29.75" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -25 0 0 1 -29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 3200 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2176 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4352 0 -1 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2176 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -3200 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="265" owner="0" type="0" pos="13 -25 -29.5" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -25 0 0 1 -29.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 3200 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1664 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3328 0 -1 0 6400 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1664 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -3200 0 0 -1 3776 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="266" owner="0" type="0" pos="13 -21 -28.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -21 0 0 1 -28.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 -1 0.749998" />
                            <Vertex pos="-1 1 -0.75" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 -1 0.75" />
                            <Vertex pos="1 1 -0.75" />
                            <Vertex pos="1 1 -0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2688 0 0 -1 3680 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 3680 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.447214 -0.894427 -0.223607" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 1 0 -2688 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-9.06304e-007 0.447214 0.894427 -0.223606" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3328 0 -1 0 5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1664 0 0 -1 3680 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2688 0 0 -1 3680 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="267" owner="0" type="0" pos="13 -23 -28.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -23 0 0 1 -28.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.250002" />
                            <Vertex pos="-1 -1 -0.75" />
                            <Vertex pos="-1 1 0.75" />
                            <Vertex pos="-1 1 0.250002" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 -0.749998" />
                            <Vertex pos="1 1 0.75" />
                            <Vertex pos="1 1 0.250002" />
                        </Vertices>
                        <Face id="0" plane="-1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2944 0 0 -1 3680 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 3680 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 1 0 4" />
                        </Face>
                        <Face id="2" plane="-8.92976e-007 -0.447214 0.894427 -0.223606" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3328 0 -1 0 5888 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 6 4 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.447214 -0.894427 -0.223606" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 1 0 -2944 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 1 5" />
                        </Face>
                        <Face id="4" plane="0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1664 0 0 -1 3680 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 2 3" />
                        </Face>
                        <Face id="5" plane="1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2944 0 0 -1 3680 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 4 6" />
                        </Face>
                    </Brush>
                    <Brush id="268" owner="0" type="0" pos="17 -19 -29.75" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 -19 0 0 1 -29.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 2432 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 2176 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1920 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 4352 0 -1 0 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -2176 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -2432 0 0 -1 3808 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="269" owner="0" type="0" pos="45.75 -20 5" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 -20 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 1" />
                            <Vertex pos="-0.75 -1.90735e-006 -1" />
                            <Vertex pos="0.25 2 1" />
                            <Vertex pos="0.75 -2 1" />
                            <Vertex pos="-0.25 -1.90735e-006 -1" />
                            <Vertex pos="0.75 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 5120 0 0 -1 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707106 -0.707108" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 -90.5122 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707106 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 -0.447214 0 -0.894427 -3649.26 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="270" owner="0" type="0" pos="45.75 -20 -1" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 -20 0 0 1 -1 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.249996 -2 -1" />
                            <Vertex pos="-0.750004 0 1" />
                            <Vertex pos="0.249996 2 -1" />
                            <Vertex pos="0.750004 -2 -1" />
                            <Vertex pos="-0.249996 0 1" />
                            <Vertex pos="0.750004 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 5120 0 0 -1 256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -995.607 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 90.5063 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 -0 0.447214 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 0.447214 0 -0.894427 2275.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="271" owner="0" type="0" pos="45.75 -19 2" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 -19 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.75 -1 -2" />
                            <Vertex pos="-0.75 -1 2" />
                            <Vertex pos="0.25 1 -4" />
                            <Vertex pos="0.25 1 4" />
                            <Vertex pos="-0.249996 -1 -2" />
                            <Vertex pos="-0.249996 -1 2" />
                            <Vertex pos="0.75 1 -4" />
                            <Vertex pos="0.75 1 4" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 4864 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 1719.69 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -2443.77 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894428 -0.447212 0 -0.223609" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 5481.05 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="272" owner="0" type="0" pos="45.75 -21 2" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 -21 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.249996 -1 -4" />
                            <Vertex pos="0.249996 -1 4" />
                            <Vertex pos="-0.750004 1 -2" />
                            <Vertex pos="-0.750004 1 2" />
                            <Vertex pos="0.750004 -1 -4" />
                            <Vertex pos="0.750004 -1 4" />
                            <Vertex pos="-0.25 1 -2" />
                            <Vertex pos="-0.25 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 5376 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -2262.74 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 1538.67 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0.447215 -0 -0.223608" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -443.631 0 0 -1 -512 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="273" owner="0" type="0" pos="45.75 -22 3" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 -22 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.75 -2 -1" />
                            <Vertex pos="0.25 -4 1" />
                            <Vertex pos="-0.75 2 -1" />
                            <Vertex pos="0.25 4 1" />
                            <Vertex pos="-0.25 -2 -1" />
                            <Vertex pos="0.749996 -4 1" />
                            <Vertex pos="-0.25 2 -1" />
                            <Vertex pos="0.75 4 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 5632 0 0 -1 -768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -0.707107 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 0.707107 -0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -2443.76 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2560 -0.447214 0 -0.894427 -3649.26 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="274" owner="0" type="0" pos="45.75 -25 2" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 -25 0 0 1 2 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -1 -2" />
                            <Vertex pos="0.25 -1 2" />
                            <Vertex pos="-0.75 1 8.34465e-007" />
                            <Vertex pos="0.750004 -1 -2" />
                            <Vertex pos="0.750004 -1 2" />
                            <Vertex pos="-0.249996 1 3.57628e-007" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 6400 0 0 -1 -512 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="-6.74344e-007 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -2081.72 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 995.608 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 0.447214 -0 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -901.577 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="275" owner="0" type="0" pos="45.75 -22 1" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 -22 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="0.25 -4 -1" />
                            <Vertex pos="-0.75 -2 1" />
                            <Vertex pos="0.25 4 -1" />
                            <Vertex pos="-0.75 2 1" />
                            <Vertex pos="0.75 -4 -1" />
                            <Vertex pos="-0.25 -2 1" />
                            <Vertex pos="0.75 4 -1" />
                            <Vertex pos="-0.25 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 5632 0 0 -1 -256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -2262.74 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -2560 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 0.707107 0.707107 -2.12132" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 1357.65 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.894427 0 0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 2560 0.447214 0 -0.894427 2275.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="276" owner="0" type="0" pos="45.75 8 33" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 8 0 0 1 33 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 1" />
                            <Vertex pos="-0.75 0 -1" />
                            <Vertex pos="0.25 2 1" />
                            <Vertex pos="0.749996 -2 1" />
                            <Vertex pos="-0.250004 0 -1" />
                            <Vertex pos="0.749996 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447214 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -2048 0 0 -1 -8448 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 -90.5142 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 0 -0.447214 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 -0.447214 0 -0.894427 -3649.27 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="277" owner="0" type="0" pos="45.75 8 31" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 8 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 -1" />
                            <Vertex pos="-0.749996 0 0.999996" />
                            <Vertex pos="0.25 2 -1" />
                            <Vertex pos="0.75 -2 -1" />
                            <Vertex pos="-0.25 0 0.999998" />
                            <Vertex pos="0.75 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894428 0 -0.447213 -0.223606" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -2048 0 0 -1 -7936 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707106 0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -995.609 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="-2.78171e-006 0.707107 0.707106 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 90.5034 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 -0 0.447214 -0.223606" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 0.447214 0 -0.894427 2275.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="278" owner="0" type="0" pos="45.75 7 32" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 7 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.249996 -1 -2" />
                            <Vertex pos="0.249996 -1 2" />
                            <Vertex pos="-0.750004 1 -3.8147e-006" />
                            <Vertex pos="0.750004 -1 -2" />
                            <Vertex pos="0.750004 -1 2" />
                            <Vertex pos="-0.249996 1 -1.90735e-006" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.22361" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -1792 0 0 -1 -8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="2.69736e-006 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -995.609 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707106 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 -90.5161 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 0.447214 -0 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -2275.43 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="279" owner="0" type="0" pos="45.75 9 32" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 9 0 0 1 32 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 -0.999999 -1.90735e-006" />
                            <Vertex pos="0.25 1 -2" />
                            <Vertex pos="0.25 1 2" />
                            <Vertex pos="-0.250004 -0.999999 0" />
                            <Vertex pos="0.749996 1 -2" />
                            <Vertex pos="0.749996 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -2304 0 0 -1 -8192 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 90.5034 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="-2.69742e-006 -0.707106 0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -0.447214 0 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 3649.27 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="280" owner="0" type="0" pos="45.75 12 37" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 12 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.250004 -2 1" />
                            <Vertex pos="-0.75 0 -1" />
                            <Vertex pos="0.250004 2 1" />
                            <Vertex pos="0.75 -2 0.999996" />
                            <Vertex pos="-0.25 -9.53674e-007 -1" />
                            <Vertex pos="0.75 2 1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 0.447215 -0.223605" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3072 0 0 -1 -9472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="-1.3487e-006 -0.707107 -0.707106 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 -90.5142 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="7.98709e-006 -9.98378e-007 1 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="0 0.707107 -0.707107 -0.707107" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 4.53153e-007 -0.447214 -0.223607" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 -0.447214 0 -0.894427 -3649.26 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="281" owner="0" type="0" pos="45.75 12 35" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 12 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -2 -1" />
                            <Vertex pos="-0.75 9.53674e-007 0.999996" />
                            <Vertex pos="0.25 2 -1" />
                            <Vertex pos="0.749996 -2 -1" />
                            <Vertex pos="-0.25 9.53674e-007 0.999996" />
                            <Vertex pos="0.75 2 -1" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0 -0.447214 -0.223608" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3072 0 0 -1 -8960 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -0.707106 0.707108 -0.707104" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -995.607 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -1 0 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707106 0.707107 -0.707105" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 90.5054 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 -8.92976e-007 0.447214 -0.223605" album="Blasted" material="bm_grid_blank4" texgens="0 1 0 768 0.447214 0 -0.894427 2275.43 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="282" owner="0" type="0" pos="45.75 11 36" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 11 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="0.25 -1 -2" />
                            <Vertex pos="0.25 -1 2" />
                            <Vertex pos="-0.75 0.999999 0" />
                            <Vertex pos="0.750004 -1 -2" />
                            <Vertex pos="0.750004 -1 2" />
                            <Vertex pos="-0.249996 0.999999 0" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 -0.447214 -0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -2816 0 0 -1 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 1 0" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 3 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 -0.707107 -0.707107 -995.607 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 0 3" />
                        </Face>
                        <Face id="3" plane="0 0.707107 0.707107 -0.707106" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0.707107 -0.707107 -90.5142 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 1 2" />
                        </Face>
                        <Face id="4" plane="0.894427 0.447214 -0 -0.22361" album="Blasted" material="bm_grid_blank4" texgens="-0.447214 0.894427 0 -2275.43 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 4" />
                        </Face>
                    </Brush>
                    <Brush id="283" owner="0" type="0" pos="45.75 13 36" rot="1 0 0 0" scale="" transform="1 0 0 45.75 0 1 0 13 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="6" nextVertexID="7">
                        <Vertices>
                            <Vertex pos="-0.75 -1 3.8147e-006" />
                            <Vertex pos="0.25 1 -2" />
                            <Vertex pos="0.25 1 2" />
                            <Vertex pos="-0.250004 -1 3.8147e-006" />
                            <Vertex pos="0.749996 1 -2" />
                            <Vertex pos="0.749996 1 2" />
                        </Vertices>
                        <Face id="0" plane="-0.894427 0.447214 0 -0.223607" album="Blasted" material="bm_friction_ice" texgens="0 -1 0 -3328 0 0 -1 -9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 2 0 1" />
                        </Face>
                        <Face id="1" plane="0 -0.707107 -0.707106 -0.707105" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 0.707107 -0.707107 90.5054 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 4 1 0 3" />
                        </Face>
                        <Face id="2" plane="0 -0.707106 0.707107 -0.707109" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 6368 0 -0.707107 -0.707107 -1176.63 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 3 0 2" />
                        </Face>
                        <Face id="3" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -6368 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 2 1 4" />
                        </Face>
                        <Face id="4" plane="0.894427 -0.447214 0 -0.223603" album="Blasted" material="bm_grid_blank4" texgens="0.447214 0.894427 0 3649.27 0 0 -1 -768 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 3" />
                        </Face>
                    </Brush>
                    <Brush id="284" owner="0" type="0" pos="12 41.75 35" rot="1 0 0 0" scale="" transform="1 0 0 12 0 1 0 41.75 0 0 1 35 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2 -0.25 -0.999996" />
                            <Vertex pos="-2 -0.25 0.999996" />
                            <Vertex pos="-2.5 0.25 -1.5" />
                            <Vertex pos="-2.5 0.25 1.5" />
                            <Vertex pos="2 -0.25 -0.999996" />
                            <Vertex pos="2 -0.25 0.999996" />
                            <Vertex pos="2.5 0.25 -1.5" />
                            <Vertex pos="2.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 8960 1 0 0 3072 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.70711 -0.707104 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.70711 0.707104 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707107 -0.707107 0 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="285" owner="0" type="0" pos="15 41.75 36" rot="1 0 0 0" scale="" transform="1 0 0 15 0 1 0 41.75 0 0 1 36 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999996 -0.25 -2" />
                            <Vertex pos="-0.999996 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.5" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="0.999997 -0.25 -2" />
                            <Vertex pos="0.999997 -0.25 2" />
                            <Vertex pos="1.5 0.25 -2.5" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707104 -0.70711 -0 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 9216 1 0 0 3840 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 639.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707105 -0.707109 0 -0.88388" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="286" owner="0" type="0" pos="17 41.75 33" rot="1 0 0 0" scale="" transform="1 0 0 17 0 1 0 41.75 0 0 1 33 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999998 -0.25 -0.999992" />
                            <Vertex pos="-0.999998 -0.25 0.999996" />
                            <Vertex pos="-1.5 0.25 -1.49999" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="0.999998 -0.25 -0.999989" />
                            <Vertex pos="0.999998 -0.25 0.999996" />
                            <Vertex pos="1.5 0.25 -1.49999" />
                            <Vertex pos="1.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707105 -0.707108 -0 -0.883881" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 8448 1 0 0 4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707105 -0.707108 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.70711 0.707104 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707105 -0.707108 0 -0.883881" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="287" owner="0" type="0" pos="13 41.75 31" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 41.75 0 0 1 31 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -0.25 -0.999994" />
                            <Vertex pos="-1 -0.25 0.999996" />
                            <Vertex pos="-1.5 0.25 -1.5" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="0.999999 -0.25 -0.999996" />
                            <Vertex pos="0.999999 -0.25 0.999996" />
                            <Vertex pos="1.5 0.25 -1.5" />
                            <Vertex pos="1.5 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -0.883883" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 7936 1 0 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707111 -0.707103 -0.883876" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.70711 0.707104 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707106 -0.707107 0 -0.883882" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="288" owner="0" type="0" pos="-21 41.75 5" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 41.75 0 0 1 5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999996 -0.25 -0.999997" />
                            <Vertex pos="-0.999996 -0.25 0.999997" />
                            <Vertex pos="-1.5 0.25 -1.5" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="0.999996 -0.25 -0.999999" />
                            <Vertex pos="0.999996 -0.25 1" />
                            <Vertex pos="1.49999 0.25 -1.5" />
                            <Vertex pos="1.49999 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707104 -0.70711 -0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 1280 1 0 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707109 -0.707105 -0.88388" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-1.05368e-006 -0.707106 0.707107 -0.883883" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707111 -0.707102 0 -0.883884" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="289" owner="0" type="0" pos="-17 41.75 3" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 41.75 0 0 1 3 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-2.99999 -0.25 -1" />
                            <Vertex pos="-2.99999 -0.25 1" />
                            <Vertex pos="-3.49999 0.25 -1.5" />
                            <Vertex pos="-3.49999 0.25 1.5" />
                            <Vertex pos="3 -0.25 -1" />
                            <Vertex pos="3 -0.25 1" />
                            <Vertex pos="3.49999 0.25 -1.5" />
                            <Vertex pos="3.49999 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707107 -0.707107 -0 -2.29809" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 767.999 1 0 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -0.883883" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -0.883883" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 384 1 0 0 896 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707114 -0.7071 0 -2.29812" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="290" owner="0" type="0" pos="-17 41.75 2.6226e-006" rot="1 0 0 0" scale="" transform="1 0 0 -17 0 1 0 41.75 0 0 1 2.6226e-006 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999996 -0.25 -2" />
                            <Vertex pos="-0.999996 -0.25 2" />
                            <Vertex pos="-1.5 0.25 -2.5" />
                            <Vertex pos="-1.5 0.25 2.5" />
                            <Vertex pos="0.999994 -0.25 -2" />
                            <Vertex pos="0.999994 -0.25 2" />
                            <Vertex pos="1.5 0.25 -2.5" />
                            <Vertex pos="1.5 0.25 2.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707104 -0.70711 -0 -0.883878" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 0.000671387 1 0 0 -4352 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707107 -0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0.707107 0.707107 -1.59099" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 639.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707103 -0.707111 0 -0.883876" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 640 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="291" owner="0" type="0" pos="-21 41.75 1" rot="1 0 0 0" scale="" transform="1 0 0 -21 0 1 0 41.75 0 0 1 1 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.999996 -0.25 -0.999997" />
                            <Vertex pos="-0.999996 -0.25 0.999997" />
                            <Vertex pos="-1.5 0.25 -1.5" />
                            <Vertex pos="-1.5 0.25 1.5" />
                            <Vertex pos="0.999996 -0.25 -0.999996" />
                            <Vertex pos="0.999996 -0.25 0.999999" />
                            <Vertex pos="1.49999 0.25 -1.5" />
                            <Vertex pos="1.49999 0.25 1.5" />
                        </Vertices>
                        <Face id="0" plane="-0.707104 -0.70711 -0 -0.883879" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -1 0 -0.25" album="Blasted" material="bm_friction_ice" texgens="0 0 1 256.001 1 0 0 -5376 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 -0.707109 -0.707105 -0.88388" album="Blasted" material="bm_edge_white" texgens="0 -1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="-6.95425e-007 -0.707107 0.707106 -0.883882" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 0 -1 383.999 1 0 0 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="0.707111 -0.707102 0 -0.883884" album="Blasted" material="bm_edge_white" texgens="0 1 0 64 0 0 -1 384 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="292" owner="0" type="0" pos="25 7 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 25 0 1 0 7 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -896 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3200 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3200 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 6400 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3200 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 896 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="293" owner="0" type="0" pos="27 7 -33.5" rot="1 0 0 0" scale="" transform="1 0 0 27 0 1 0 7 0 0 1 -33.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.5" />
                            <Vertex pos="-1 -1 0.5" />
                            <Vertex pos="-1 1 -0.5" />
                            <Vertex pos="-1 1 0.5" />
                            <Vertex pos="1 -1 -0.5" />
                            <Vertex pos="1 -1 0.5" />
                            <Vertex pos="1 1 -0.5" />
                            <Vertex pos="1 1 0.5" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -896 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3456 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.5" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3456 0 -1 0 -1152 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.5" album="Blasted" material="bm_friction_ice" texgens="1 0 0 6912 0 -1 0 -1792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3456 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 896 0 0 -1 4288 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="294" owner="0" type="0" pos="29 5 -33.75" rot="1 0 0 0" scale="" transform="1 0 0 29 0 1 0 5 0 0 1 -33.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 -640 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 3712 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -3712 0 -1 0 -896 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 7424 0 -1 0 -1280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -3712 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 640 0 0 -1 4320 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="295" owner="0" type="0" pos="13 -13 -31.75" rot="1 0 0 0" scale="" transform="1 0 0 13 0 1 0 -13 0 0 1 -31.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-1 -1 -0.25" />
                            <Vertex pos="-1 -1 0.25" />
                            <Vertex pos="-1 1 -0.25" />
                            <Vertex pos="-1 1 0.25" />
                            <Vertex pos="1 -1 -0.25" />
                            <Vertex pos="1 -1 0.25" />
                            <Vertex pos="1 1 -0.25" />
                            <Vertex pos="1 1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 -1 0 1664 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="1 0 0 1664 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="-1 0 0 -1408 0 -1 0 1920 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_friction_ice" texgens="1 0 0 3328 0 -1 0 3328 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="512 512">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -1" album="Blasted" material="bm_grid_blank3" texgens="-1 0 0 -1664 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -1" album="Blasted" material="bm_grid_blank3" texgens="0 1 0 -1664 0 0 -1 4064 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="296" owner="0" type="0" pos="46 -28.25 -24.25" rot="1 0 0 0" scale="" transform="1 0 0 46 0 1 0 -28.25 0 0 1 -24.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-6 -0.25 -3.75" />
                            <Vertex pos="-6 -0.25 0.25" />
                            <Vertex pos="-6 0.25 -3.75" />
                            <Vertex pos="-6 0.25 0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 -0.25 0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                            <Vertex pos="-2 0.25 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -6" album="Blasted" material="bm_edge_white" texgens="0 0 1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="-0 -1 -0 -0.25" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 512 0 0 1 480 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0.707107 0 -0.707107 1.59099" album="Blasted" material="bm_edge_white" texgens="-1 0 0 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 1536 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0.25" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 512 0 0 -1 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 2" album="Blasted" material="bm_edge_white" texgens="0 0 -1 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="297" owner="0" type="0" pos="-24.25 36.25 -25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 36.25 0 0 1 -25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -0.25 -3" />
                            <Vertex pos="-0.25 -0.25 1" />
                            <Vertex pos="-0.25 3.75 1" />
                            <Vertex pos="-0.25 3.75 1" />
                            <Vertex pos="0.25 -0.25 -3" />
                            <Vertex pos="0.25 -0.25 1" />
                            <Vertex pos="0.25 3.75 1" />
                            <Vertex pos="0.25 3.75 1" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_grid_blank4" texgens="0 0 1 128 0 1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0.707107 -0.707107 -1.94454" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 1 0 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0 1 0 -3.75" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -0.25" album="Blasted" material="bm_grid_blank4" texgens="0 0 -1 -128 0 1 0 32 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="298" owner="0" type="0" pos="40.25 37 40.25" rot="1 0 0 0" scale="" transform="1 0 0 40.25 0 1 0 37 0 0 1 40.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.25 -1 -0.25" />
                            <Vertex pos="-0.25 -1 0.25" />
                            <Vertex pos="-0.25 3 -0.25" />
                            <Vertex pos="-0.25 3 0.25" />
                            <Vertex pos="3.75 -1 -0.25" />
                            <Vertex pos="3.75 -1 0.25" />
                            <Vertex pos="3.75 -1 -0.25" />
                            <Vertex pos="3.75 -1 0.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.25" album="Blasted" material="bm_edge_white" texgens="0 -1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -1" album="Blasted" material="bm_edge_white" texgens="1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -224 0 1 0 128 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 0 1 -0.25" album="Blasted" material="bm_grid_blank4" texgens="1 0 0 -224 0 -1 0 384 0 0.25 0.25" texRot="0" texScale="0.25 0.25" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="0.707107 0.707107 0 -1.94454" album="Blasted" material="bm_edge_white" texgens="-1 0 0 64 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 0 -3.75" album="Blasted" material="bm_edge_white" texgens="0 1 0 768 0 0 -1 64 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="128 128">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="299" owner="0" type="0" pos="-24.25 28.25 -30.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 28.25 0 0 1 -30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 7.75 2.5" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 7.75 2.5" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -7808 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 7808 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="300" owner="0" type="0" pos="-24.25 28.25 -24.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 28.25 0 0 1 -24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 5.75 2.5" />
                            <Vertex pos="-0.125 5.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 5.75 2.5" />
                            <Vertex pos="0.125 5.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -6336 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -6336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 6336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 6336 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="301" owner="0" type="0" pos="-24.25 34.25 -18.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 34.25 0 0 1 -18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 5.75 2.5" />
                            <Vertex pos="-0.125 5.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 5.75 2.5" />
                            <Vertex pos="0.125 5.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -4800 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 4800 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="302" owner="0" type="0" pos="-24.25 32.25 -26.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 32.25 0 0 1 -26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 3.75 2.5" />
                            <Vertex pos="-0.125 3.75 2.75" />
                            <Vertex pos="-0.125 7.75 2.5" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 3.75 2.5" />
                            <Vertex pos="0.125 3.75 2.75" />
                            <Vertex pos="0.125 7.75 2.5" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -6784 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -6784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 6784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 6784 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="303" owner="0" type="0" pos="-24.25 32.25 -19" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 32.25 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -4.75" />
                            <Vertex pos="-0.125 7.5 2.75" />
                            <Vertex pos="-0.125 7.75 -4.75" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 7.5 -4.75" />
                            <Vertex pos="0.125 7.5 2.75" />
                            <Vertex pos="0.125 7.75 -4.75" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -4864 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -4.75" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 4864 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="304" owner="0" type="0" pos="-24.25 26.5 -19" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 26.5 0 0 1 -19 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 2.75" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 2.75" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -4864 0 1 0 6784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 6784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 6784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 4864 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 4864 0 1 0 6784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="305" owner="0" type="0" pos="-24.25 28.25 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 28.25 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 0.75" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 0.75" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 0.75" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 0.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -6272 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 6272 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="306" owner="0" type="0" pos="-24.25 20.5 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 20.5 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 2.25" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 2.25" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 2.25" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 2.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -6272 0 1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 6272 0 1 0 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="307" owner="0" type="0" pos="-24.25 -27.75 -34.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 -27.75 0 0 1 -34.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 17.75 2.5" />
                            <Vertex pos="-0.125 17.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 17.75 2.5" />
                            <Vertex pos="0.125 17.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -8832 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -8832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -17.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 8832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 8832 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="308" owner="0" type="0" pos="-24.25 -27.75 -28.75" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 -27.75 0 0 1 -28.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 17.75 2.5" />
                            <Vertex pos="-0.125 17.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 17.75 2.5" />
                            <Vertex pos="0.125 17.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -7360 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -7360 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -17.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 7360 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 7360 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="309" owner="0" type="0" pos="-24.25 -35.5 -28.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 -35.5 0 0 1 -28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 2.25" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 2.25" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 2.25" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 2.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -7296 0 1 0 -9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -7296 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 -9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 -9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 7296 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 7296 0 1 0 -9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="310" owner="0" type="0" pos="-24.25 -17.75 -28.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 -17.75 0 0 1 -28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 2.25" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 2.25" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 2.25" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 2.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -7296 0 1 0 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 -7296 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 7296 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 7296 0 1 0 -4544 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="311" owner="0" type="0" pos="-23.875 -28.125 -34.5" rot="1 0 0 0" scale="" transform="1 0 0 -23.875 0 1 0 -28.125 0 0 1 -34.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 0 2.5" />
                            <Vertex pos="-0.125 0 2.75" />
                            <Vertex pos="17.875 -0.25 2.5" />
                            <Vertex pos="17.875 -0.25 2.75" />
                            <Vertex pos="17.875 0 2.5" />
                            <Vertex pos="17.875 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -8832 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 0 1 -8832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6112 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 0 -1 8832 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -17.875" album="Blasted" material="bm_wood" texgens="0 0 -1 8832 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="312" owner="0" type="0" pos="-23.875 -28.125 -28.75" rot="1 0 0 0" scale="" transform="1 0 0 -23.875 0 1 0 -28.125 0 0 1 -28.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 0 2.5" />
                            <Vertex pos="-0.125 0 2.75" />
                            <Vertex pos="17.875 -0.25 2.5" />
                            <Vertex pos="17.875 -0.25 2.75" />
                            <Vertex pos="17.875 0 2.5" />
                            <Vertex pos="17.875 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -7360 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 0 1 -7360 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6112 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 0 -1 7360 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -17.875" album="Blasted" material="bm_wood" texgens="0 0 -1 7360 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="313" owner="0" type="0" pos="-23.875 -35.875 -28.5" rot="1 0 0 0" scale="" transform="1 0 0 -23.875 0 1 0 -35.875 0 0 1 -28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 2.25" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 2.25" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 2.25" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 2.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -7296 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 0 1 -7296 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 6112 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 0 -1 7296 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 7296 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="314" owner="0" type="0" pos="-6.125 -35.875 -28.5" rot="1 0 0 0" scale="" transform="1 0 0 -6.125 0 1 0 -35.875 0 0 1 -28.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 2.25" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 2.25" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 2.25" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 2.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -7296 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -1568 0 0 1 -7296 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 1568 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.25" album="Blasted" material="bm_wood" texgens="1 0 0 -1568 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -1568 0 0 -1 7296 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 7296 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="319" owner="0" type="0" pos="32.125 -28.125 -30.5" rot="1 0 0 0" scale="" transform="1 0 0 32.125 0 1 0 -28.125 0 0 1 -30.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 0 2.5" />
                            <Vertex pos="-0.125 0 2.75" />
                            <Vertex pos="7.875 -0.25 2.5" />
                            <Vertex pos="7.875 -0.25 2.75" />
                            <Vertex pos="7.875 0 2.5" />
                            <Vertex pos="7.875 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -7808 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 0 1 -7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -8224 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 0 -1 7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.875" album="Blasted" material="bm_wood" texgens="0 0 -1 7808 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="320" owner="0" type="0" pos="32.125 -28.125 -24.75" rot="1 0 0 0" scale="" transform="1 0 0 32.125 0 1 0 -28.125 0 0 1 -24.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 0 2.5" />
                            <Vertex pos="-0.125 0 2.75" />
                            <Vertex pos="5.875 -0.25 2.5" />
                            <Vertex pos="5.875 -0.25 2.75" />
                            <Vertex pos="5.875 0 2.5" />
                            <Vertex pos="5.875 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -6336 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 0 1 -6336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -8224 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 0 -1 6336 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -5.875" album="Blasted" material="bm_wood" texgens="0 0 -1 6336 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="321" owner="0" type="0" pos="32.125 -35.875 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 32.125 0 1 0 -35.875 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 2.25" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 2.25" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 2.25" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 2.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -6272 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 0 1 -6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -8224 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.25" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 0 -1 6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 6272 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="322" owner="0" type="0" pos="39.875 -35.875 -24.5" rot="1 0 0 0" scale="" transform="1 0 0 39.875 0 1 0 -35.875 0 0 1 -24.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 0.75" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 0.75" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 0.75" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 0.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -6272 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 10208 0 0 1 -6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -10208 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -0.75" album="Blasted" material="bm_wood" texgens="1 0 0 10208 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 10208 0 0 -1 6272 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 6272 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="323" owner="0" type="0" pos="36.125 -28.125 -26.5" rot="1 0 0 0" scale="" transform="1 0 0 36.125 0 1 0 -28.125 0 0 1 -26.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.875 -0.25 2.5" />
                            <Vertex pos="3.875 -0.25 2.75" />
                            <Vertex pos="3.875 0 2.5" />
                            <Vertex pos="3.875 0 2.75" />
                            <Vertex pos="7.875 -0.25 2.5" />
                            <Vertex pos="7.875 -0.25 2.75" />
                            <Vertex pos="7.875 0 2.5" />
                            <Vertex pos="7.875 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 3.875" album="Blasted" material="bm_wood" texgens="0 0 1 -6784 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 9248 0 0 1 -6784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -9248 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 9248 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 9248 0 0 -1 6784 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.875" album="Blasted" material="bm_wood" texgens="0 0 -1 6784 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="324" owner="0" type="0" pos="36.125 -28.125 -18.75" rot="1 0 0 0" scale="" transform="1 0 0 36.125 0 1 0 -28.125 0 0 1 -18.75 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.875 -0.25 2.5" />
                            <Vertex pos="1.875 -0.25 2.75" />
                            <Vertex pos="1.875 0 2.5" />
                            <Vertex pos="1.875 0 2.75" />
                            <Vertex pos="7.875 -0.25 2.5" />
                            <Vertex pos="7.875 -0.25 2.75" />
                            <Vertex pos="7.875 0 2.5" />
                            <Vertex pos="7.875 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 1.875" album="Blasted" material="bm_wood" texgens="0 0 1 -4800 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 9248 0 0 1 -4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -9248 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 9248 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 9248 0 0 -1 4800 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.875" album="Blasted" material="bm_wood" texgens="0 0 -1 4800 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="325" owner="0" type="0" pos="43.875 -35.875 -20.5" rot="1 0 0 0" scale="" transform="1 0 0 43.875 0 1 0 -35.875 0 0 1 -20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -3.25" />
                            <Vertex pos="-0.125 7.5 4.25" />
                            <Vertex pos="-0.125 7.75 -3.25" />
                            <Vertex pos="-0.125 7.75 4.25" />
                            <Vertex pos="0.125 7.5 -3.25" />
                            <Vertex pos="0.125 7.5 4.25" />
                            <Vertex pos="0.125 7.75 -3.25" />
                            <Vertex pos="0.125 7.75 4.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -5248 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 11232 0 0 1 -5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -3.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -11232 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4.25" album="Blasted" material="bm_wood" texgens="1 0 0 11232 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 11232 0 0 -1 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 5248 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="326" owner="0" type="0" pos="38.125 -35.875 -20.5" rot="1 0 0 0" scale="" transform="1 0 0 38.125 0 1 0 -35.875 0 0 1 -20.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -1.75" />
                            <Vertex pos="-0.125 7.5 4.25" />
                            <Vertex pos="-0.125 7.75 -1.75" />
                            <Vertex pos="-0.125 7.75 4.25" />
                            <Vertex pos="0.125 7.5 -1.75" />
                            <Vertex pos="0.125 7.5 4.25" />
                            <Vertex pos="0.125 7.75 -1.75" />
                            <Vertex pos="0.125 7.75 4.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 -5248 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 9760 0 0 1 -5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -1.75" album="Blasted" material="bm_wood" texgens="-1 0 0 -9760 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4.25" album="Blasted" material="bm_wood" texgens="1 0 0 9760 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 9760 0 0 -1 5248 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 5248 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="327" owner="0" type="0" pos="40.125 -28.125 19.5" rot="1 0 0 0" scale="" transform="1 0 0 40.125 0 1 0 -28.125 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.875 -0.25 2.5" />
                            <Vertex pos="1.875 -0.25 2.75" />
                            <Vertex pos="1.875 0 2.5" />
                            <Vertex pos="1.875 0 2.75" />
                            <Vertex pos="7.875 -0.25 2.5" />
                            <Vertex pos="7.875 -0.25 2.75" />
                            <Vertex pos="7.875 0 2.5" />
                            <Vertex pos="7.875 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 1.875" album="Blasted" material="bm_wood" texgens="0 0 1 4992 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 10272 0 0 1 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -10272 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 10272 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 10272 0 0 -1 -4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.875" album="Blasted" material="bm_wood" texgens="0 0 -1 -4992 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="328" owner="0" type="0" pos="40.125 -28.125 37.25" rot="1 0 0 0" scale="" transform="1 0 0 40.125 0 1 0 -28.125 0 0 1 37.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.875 -0.25 2.5" />
                            <Vertex pos="1.875 -0.25 2.75" />
                            <Vertex pos="1.875 0 2.5" />
                            <Vertex pos="1.875 0 2.75" />
                            <Vertex pos="7.875 -0.25 2.5" />
                            <Vertex pos="7.875 -0.25 2.75" />
                            <Vertex pos="7.875 0 2.5" />
                            <Vertex pos="7.875 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 1.875" album="Blasted" material="bm_wood" texgens="0 0 1 9536 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 10272 0 0 1 9536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -10272 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 10272 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 10272 0 0 -1 -9536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.875" album="Blasted" material="bm_wood" texgens="0 0 -1 -9536 0 1 0 -7200 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="329" owner="0" type="0" pos="47.875 -35.875 35.5" rot="1 0 0 0" scale="" transform="1 0 0 47.875 0 1 0 -35.875 0 0 1 35.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -13.25" />
                            <Vertex pos="-0.125 7.5 4.25" />
                            <Vertex pos="-0.125 7.75 -13.25" />
                            <Vertex pos="-0.125 7.75 4.25" />
                            <Vertex pos="0.125 7.5 -13.25" />
                            <Vertex pos="0.125 7.5 4.25" />
                            <Vertex pos="0.125 7.75 -13.25" />
                            <Vertex pos="0.125 7.75 4.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9088 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 12256 0 0 1 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -13.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -12256 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4.25" album="Blasted" material="bm_wood" texgens="1 0 0 12256 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 12256 0 0 -1 -9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9088 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="330" owner="0" type="0" pos="42.125 -35.875 35.5" rot="1 0 0 0" scale="" transform="1 0 0 42.125 0 1 0 -35.875 0 0 1 35.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -13.25" />
                            <Vertex pos="-0.125 7.5 4.25" />
                            <Vertex pos="-0.125 7.75 -13.25" />
                            <Vertex pos="-0.125 7.75 4.25" />
                            <Vertex pos="0.125 7.5 -13.25" />
                            <Vertex pos="0.125 7.5 4.25" />
                            <Vertex pos="0.125 7.75 -13.25" />
                            <Vertex pos="0.125 7.75 4.25" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9088 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 10784 0 0 1 9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -13.25" album="Blasted" material="bm_wood" texgens="-1 0 0 -10784 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -4.25" album="Blasted" material="bm_wood" texgens="1 0 0 10784 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 10784 0 0 -1 -9088 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9088 0 1 0 -9184 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="331" owner="0" type="0" pos="40.375 -27.75 37.625" rot="1 0 0 0" scale="" transform="1 0 0 40.375 0 1 0 -27.75 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.875 -0.25 2.5" />
                            <Vertex pos="1.875 -0.25 2.75" />
                            <Vertex pos="1.875 0 2.5" />
                            <Vertex pos="1.875 0 2.75" />
                            <Vertex pos="7.375 -0.25 2.5" />
                            <Vertex pos="7.375 -0.25 2.75" />
                            <Vertex pos="7.375 0 2.5" />
                            <Vertex pos="7.375 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 1.875" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 10336 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -10336 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 10336 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 10336 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.375" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="332" owner="0" type="0" pos="40.375 -10 37.625" rot="1 0 0 0" scale="" transform="1 0 0 40.375 0 1 0 -10 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.875 -0.25 2.5" />
                            <Vertex pos="1.875 -0.25 2.75" />
                            <Vertex pos="1.875 0 2.5" />
                            <Vertex pos="1.875 0 2.75" />
                            <Vertex pos="7.375 -0.25 2.5" />
                            <Vertex pos="7.375 -0.25 2.75" />
                            <Vertex pos="7.375 0 2.5" />
                            <Vertex pos="7.375 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 1.875" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 10336 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -10336 0 1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 10336 0 1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 10336 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.375" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 -2560 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="333" owner="0" type="0" pos="42.125 -27.75 37.625" rot="1 0 0 0" scale="" transform="1 0 0 42.125 0 1 0 -27.75 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 17.75 2.5" />
                            <Vertex pos="-0.125 17.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 17.75 2.5" />
                            <Vertex pos="0.125 17.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 10784 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -10784 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 10784 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -17.75" album="Blasted" material="bm_wood" texgens="1 0 0 10784 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="334" owner="0" type="0" pos="47.875 -27.75 37.625" rot="1 0 0 0" scale="" transform="1 0 0 47.875 0 1 0 -27.75 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 17.75 2.5" />
                            <Vertex pos="-0.125 17.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 17.75 2.5" />
                            <Vertex pos="0.125 17.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 12256 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -12256 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 12256 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -17.75" album="Blasted" material="bm_wood" texgens="1 0 0 12256 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 -7104 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="335" owner="0" type="0" pos="36.375 28.25 37.625" rot="1 0 0 0" scale="" transform="1 0 0 36.375 0 1 0 28.25 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.875 -0.25 2.5" />
                            <Vertex pos="1.875 -0.25 2.75" />
                            <Vertex pos="1.875 0 2.5" />
                            <Vertex pos="1.875 0 2.75" />
                            <Vertex pos="7.375 -0.25 2.5" />
                            <Vertex pos="7.375 -0.25 2.75" />
                            <Vertex pos="7.375 0 2.5" />
                            <Vertex pos="7.375 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 1.875" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 9312 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -9312 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 9312 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 9312 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.375" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="336" owner="0" type="0" pos="36.375 36 37.625" rot="1 0 0 0" scale="" transform="1 0 0 36.375 0 1 0 36 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="3.375 -0.25 2.5" />
                            <Vertex pos="3.375 -0.25 2.75" />
                            <Vertex pos="3.375 0 2.5" />
                            <Vertex pos="3.375 0 2.75" />
                            <Vertex pos="7.375 -0.25 2.5" />
                            <Vertex pos="7.375 -0.25 2.75" />
                            <Vertex pos="7.375 0 2.5" />
                            <Vertex pos="7.375 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 3.375" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 9312 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -9312 0 1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 9312 0 1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 9312 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.375" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 9216 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="337" owner="0" type="0" pos="38.125 28.25 37.625" rot="1 0 0 0" scale="" transform="1 0 0 38.125 0 1 0 28.25 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 5.75 2.5" />
                            <Vertex pos="-0.125 5.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 5.75 2.5" />
                            <Vertex pos="0.125 5.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 9760 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -9760 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 9760 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5.75" album="Blasted" material="bm_wood" texgens="1 0 0 9760 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="338" owner="0" type="0" pos="43.875 28.25 37.625" rot="1 0 0 0" scale="" transform="1 0 0 43.875 0 1 0 28.25 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 7.75 2.5" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 7.75 2.5" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 11232 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -11232 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 11232 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 11232 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 7232 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="339" owner="0" type="0" pos="32.125 34.25 37.625" rot="1 0 0 0" scale="" transform="1 0 0 32.125 0 1 0 34.25 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 5.75 2.5" />
                            <Vertex pos="-0.125 5.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 5.75 2.5" />
                            <Vertex pos="0.125 5.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -8224 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5.75" album="Blasted" material="bm_wood" texgens="1 0 0 8224 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="340" owner="0" type="0" pos="30.875 34.25 37.625" rot="1 0 0 0" scale="" transform="1 0 0 30.875 0 1 0 34.25 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.375 -0.25 2.5" />
                            <Vertex pos="1.375 -0.25 2.75" />
                            <Vertex pos="1.375 0 2.5" />
                            <Vertex pos="1.375 0 2.75" />
                            <Vertex pos="7.375 -0.25 2.5" />
                            <Vertex pos="7.375 -0.25 2.75" />
                            <Vertex pos="7.375 0 2.5" />
                            <Vertex pos="7.375 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 1.375" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 7904 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -7904 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 7904 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 7904 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.375" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 8768 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="341" owner="0" type="0" pos="39.875 32.25 37.625" rot="1 0 0 0" scale="" transform="1 0 0 39.875 0 1 0 32.25 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 3.75 2.5" />
                            <Vertex pos="-0.125 3.75 2.75" />
                            <Vertex pos="-0.125 7.75 2.5" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 3.75 2.5" />
                            <Vertex pos="0.125 3.75 2.75" />
                            <Vertex pos="0.125 7.75 2.5" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 3.75" album="Blasted" material="bm_wood" texgens="1 0 0 10208 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -10208 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 10208 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 10208 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 8256 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="343" owner="0" type="0" pos="32.375 40 37.625" rot="1 0 0 0" scale="" transform="1 0 0 32.375 0 1 0 40 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 0 2.5" />
                            <Vertex pos="-0.125 0 2.75" />
                            <Vertex pos="7.375 -0.25 2.5" />
                            <Vertex pos="7.375 -0.25 2.75" />
                            <Vertex pos="7.375 0 2.5" />
                            <Vertex pos="7.375 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 8288 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 -8288 0 1 0 10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 8288 0 1 0 10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 8288 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -7.375" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 10240 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="344" owner="0" type="0" pos="-23.875 38.25 37.625" rot="1 0 0 0" scale="" transform="1 0 0 -23.875 0 1 0 38.25 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 5.75 2.5" />
                            <Vertex pos="-0.125 5.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 5.75 2.5" />
                            <Vertex pos="0.125 5.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6112 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6112 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="345" owner="0" type="0" pos="-25.125 38.25 37.625" rot="1 0 0 0" scale="" transform="1 0 0 -25.125 0 1 0 38.25 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="1.375 -0.25 2.5" />
                            <Vertex pos="1.375 -0.25 2.75" />
                            <Vertex pos="1.375 0 2.5" />
                            <Vertex pos="1.375 0 2.75" />
                            <Vertex pos="18.875 -0.25 2.5" />
                            <Vertex pos="18.875 -0.25 2.75" />
                            <Vertex pos="18.875 0 2.5" />
                            <Vertex pos="18.875 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 1.375" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6432 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6432 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6432 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -6432 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -18.875" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="346" owner="0" type="0" pos="-23.625 44 37.625" rot="1 0 0 0" scale="" transform="1 0 0 -23.625 0 1 0 44 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 0 2.5" />
                            <Vertex pos="-0.125 0 2.75" />
                            <Vertex pos="17.375 -0.25 2.5" />
                            <Vertex pos="17.375 -0.25 2.75" />
                            <Vertex pos="17.375 0 2.5" />
                            <Vertex pos="17.375 0 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 11264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6048 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6048 0 1 0 11264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6048 0 1 0 11264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -0" album="Blasted" material="bm_wood" texgens="1 0 0 -6048 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -17.375" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 11264 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="347" owner="0" type="0" pos="-6.125 36.25 37.625" rot="1 0 0 0" scale="" transform="1 0 0 -6.125 0 1 0 36.25 0 0 1 37.625 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 1.75 2.5" />
                            <Vertex pos="-0.125 1.75 2.75" />
                            <Vertex pos="-0.125 7.75 2.5" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 1.75 2.5" />
                            <Vertex pos="0.125 1.75 2.75" />
                            <Vertex pos="0.125 7.75 2.5" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9632 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 1.75" album="Blasted" material="bm_wood" texgens="1 0 0 -1568 0 0 1 9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 1568 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -1568 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -1568 0 0 -1 -9632 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9632 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="348" owner="0" type="0" pos="-24.25 38.25 37.25" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 38.25 0 0 1 37.25 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 -0.25 2.5" />
                            <Vertex pos="-0.125 -0.25 2.75" />
                            <Vertex pos="-0.125 5.75 2.5" />
                            <Vertex pos="-0.125 5.75 2.75" />
                            <Vertex pos="0.125 -0.25 2.5" />
                            <Vertex pos="0.125 -0.25 2.75" />
                            <Vertex pos="0.125 5.75 2.5" />
                            <Vertex pos="0.125 5.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9536 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 -0.25" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 9536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -5.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 -9536 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9536 0 1 0 9792 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="349" owner="0" type="0" pos="-24.25 36.25 19.5" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 36.25 0 0 1 19.5 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 1.75 2.5" />
                            <Vertex pos="-0.125 1.75 2.75" />
                            <Vertex pos="-0.125 7.75 2.5" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 1.75 2.5" />
                            <Vertex pos="0.125 1.75 2.75" />
                            <Vertex pos="0.125 7.75 2.5" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 4992 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 1.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 2.5" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 -4992 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -4992 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="350" owner="0" type="0" pos="-24.25 36.25 37" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 36.25 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -14.75" />
                            <Vertex pos="-0.125 7.5 2.75" />
                            <Vertex pos="-0.125 7.75 -14.75" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 7.5 -14.75" />
                            <Vertex pos="0.125 7.5 2.75" />
                            <Vertex pos="0.125 7.75 -14.75" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9472 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 9472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -14.75" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 -9472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9472 0 1 0 9280 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                    <Brush id="351" owner="0" type="0" pos="-24.25 30.5 37" rot="1 0 0 0" scale="" transform="1 0 0 -24.25 0 1 0 30.5 0 0 1 37 0 0 0 1" group="-1" locked="0" nextFaceID="7" nextVertexID="9">
                        <Vertices>
                            <Vertex pos="-0.125 7.5 -14.75" />
                            <Vertex pos="-0.125 7.5 2.75" />
                            <Vertex pos="-0.125 7.75 -14.75" />
                            <Vertex pos="-0.125 7.75 2.75" />
                            <Vertex pos="0.125 7.5 -14.75" />
                            <Vertex pos="0.125 7.5 2.75" />
                            <Vertex pos="0.125 7.75 -14.75" />
                            <Vertex pos="0.125 7.75 2.75" />
                        </Vertices>
                        <Face id="0" plane="-1 0 0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 1 9472 0 1 0 7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 3 1 0 2" />
                        </Face>
                        <Face id="1" plane="0 -1 0 7.5" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 1 9472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 5 4 0 1" />
                        </Face>
                        <Face id="2" plane="0 0 -1 -14.75" album="Blasted" material="bm_wood" texgens="-1 0 0 6208 0 1 0 7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 6 2 0 4" />
                        </Face>
                        <Face id="3" plane="0 -0 1 -2.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 1 0 7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 5 1 3" />
                        </Face>
                        <Face id="4" plane="-0 1 0 -7.75" album="Blasted" material="bm_wood" texgens="1 0 0 -6208 0 0 -1 -9472 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 3 2 6" />
                        </Face>
                        <Face id="5" plane="1 0 -0 -0.125" album="Blasted" material="bm_wood" texgens="0 0 -1 -9472 0 1 0 7808 0 0.125 0.125" texRot="0" texScale="0.125 0.125" texDiv="256 256">
                            <Indices indices=" 7 6 4 5" />
                        </Face>
                    </Brush>
                </Brushes>
            </InteriorMap>
        </DetailLevel>
    </DetailLevels>
</ConstructorScene>
